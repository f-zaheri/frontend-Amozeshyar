using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amozeshyar.Models;
using Amozeshyar.Database;
using Amozeshyar.Models.Requests;
using Amozeshyar.Models.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Amozeshyar.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly AmozeshyarDB _db;

        public AuthenticationController(AmozeshyarDB db)
        {
            this._db = db;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (_db.Managers.Count()==0)
            {
                byte[] salt = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
                string phashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: "مدیر",
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
                    
                _db.Managers.Add(new Manager{
                    Firstname="مدیر",
                    Lastname="سیستم",
                    Password=phashed,
                    Mobile="مدیر",
                    Salt=salt
                });
                await _db.SaveChangesAsync();
            }
            IPerson user;
            user= await _db.Managers.FirstOrDefaultAsync(m=>m.Mobile==loginRequest.Mobile);
            if (user==null)
            {
            user= await _db.Professors.FirstOrDefaultAsync(m=>m.Mobile==loginRequest.Mobile);
            }
            if (user==null)
            {
            user= await _db.Interns.FirstOrDefaultAsync(m=>m.Mobile==loginRequest.Mobile);
            }
            if(user==null)
            {
                return Ok(new LoginResponse
                {
                IsAthenticated=false,
                Message="نام کاربری یا کلمه عبور صحیح نمی باشد"
                });
            }
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: loginRequest.Password,
                    salt: user.Salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));   
            if(hashed==user.Password)
            {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key=ASCIIEncoding.ASCII.GetBytes("ms4*^7ekv581.bB?>0<./3td4>cx!$%,");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                     new Claim("Mobile", user.Mobile.ToString()),
                     new Claim("Role", user.Role)
                     }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
                return Ok(new LoginResponse
                {
                IsAthenticated=true,
                Message="ورود موفقیت آمیز",
                Token=tokenHandler.WriteToken(token),
                Role=user.Role
                });
            }
            return Ok(new LoginResponse
            {
                IsAthenticated=false,
                Message="نام کاربری یا کلمه عبور صحیح نمی باشد"

            });

        }
    }
}
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginRequest } from '../model/LoginRequest';
import { LoginResponse } from '../model/LoginResponse';
import { BackendService } from '../services/backend.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  loginRequest:LoginRequest;
  loginResponse:LoginResponse;


  constructor(private backend:BackendService,private router:Router) { }

  ngOnInit(): void {
    this.loginRequest=new LoginRequest;
  }
  async login(){
    this.loginResponse=(await this.backend.LoginRequest(this.loginRequest)) as LoginResponse;
    if (this.loginResponse.isAthenticated==true) {
      sessionStorage.setItem('token',this.loginResponse.token);
      sessionStorage.setItem('role',this.loginResponse.role);
      if (this.loginResponse.role=='Intern') {
        this.router.navigate(['/users/interns']);
      }
      else if (this.loginResponse.role=='Professor') {
        this.router.navigate(['/users/professors']);
      }
      else if (this.loginResponse.role=='Manager') {
        this.router.navigate(['/users/managers']);
      }
    }
  }

}

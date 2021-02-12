import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ok } from 'assert';
import { RegisterRequest } from '../model/RegisterRequest';
import { RegisterResponse } from '../model/RegisterResponse';
import { BackendService } from '../services/backend.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  registerRequest:RegisterRequest;
  registerResponse:RegisterResponse;
  confirmPassword:string;

  constructor(private backend:BackendService,private router:Router) { }

  ngOnInit(): void {
    this.registerRequest=new RegisterRequest;
  }
  async register(){
    this.registerResponse=(await this.backend.RegisterRequest(this.registerRequest)) as RegisterResponse;
    this.router.navigate(['/login']);
  }
  isValid():boolean{
    if (this.registerRequest.mobile==undefined || this.registerRequest.mobile=='') {
      return false;
    }
    if (this.confirmPassword!==this.registerRequest.password) {
      return false;
    }
    return true;
  }
}

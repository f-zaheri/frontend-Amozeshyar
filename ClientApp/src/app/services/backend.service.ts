import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { promise } from 'protractor';
import { LoginRequest } from '../model/LoginRequest';
import { RegisterRequest } from '../model/RegisterRequest';

@Injectable({
  providedIn: 'root'
})
export class BackendService {

  constructor(private http:HttpClient) { }
  async RegisterRequest(request:RegisterRequest)
  {
    return this.http.post('/api/interns',request).toPromise();
  }
   async LoginRequest(request:LoginRequest)
   {
     return this.http.post('/Authentication/Login',request).toPromise();
   }
}

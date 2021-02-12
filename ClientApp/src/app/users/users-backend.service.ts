import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BackendService } from '../services/backend.service';

@Injectable()
export class UsersBackendService extends BackendService {

  constructor(private uhttp:HttpClient) {
    super(uhttp);
   }
   async post (action:string,data){
     return this.uhttp.post(action,data).toPromise();
   }
   async get (action:string){
    return this.uhttp.get(action).toPromise();
  }
}

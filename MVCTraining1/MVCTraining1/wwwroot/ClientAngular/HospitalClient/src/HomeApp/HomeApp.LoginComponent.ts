import { Component } from '@angular/core';
import { HttpClient , HttpHeaders } from "@angular/common/http";
import { SecurityCheck } from 'src/Security/Security.Token';
import { Router } from '@angular/router';

import { Users } from "./HomeApp.LoginModel";

@Component({
  selector: 'app-root',
  templateUrl: './HomeApp.LoginPage.html',
  //styleUrls: ['./app.component.css']
})
export class LoginComponent {
  UserObj:Users = new Users();
  UsersList:Array<Users> = new Array();
  constructor(public SecureObj:SecurityCheck , public _router : Router , public httpObj:HttpClient){      
  }
  Login()
  {
    // this.SecureObj.tokenValue = "token";
    // this._router.navigate(['/Patient/Add']);
    this.UsersList.push(this.UserObj);
    const headers = new HttpHeaders().set('Content-Type' , 'application/json ; charset = utf-8');
    var observable = this.httpObj.post("https://localhost:44376/api/Security" , JSON.stringify(this.UserObj), {headers,responseType : 'text'});
    this.SecureObj.tokenValue = "";
    console.log(this.UserObj.user , this.UserObj.password);
    observable.subscribe(res=>this.Success(res) , res=>this.Error(res));
  }
  Success(res){
    this.SecureObj.tokenValue = res;
    console.log(this.SecureObj.tokenValue);
    this._router.navigate(['Master']);
  }
  Error(res){

  }
}


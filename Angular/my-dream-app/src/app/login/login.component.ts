import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { _getViewData } from '@angular/core/src/render3/instructions';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})


export class LoginComponent implements OnInit {
    buttonTitle:string="Submit";
    username:string="";
    password:string="";
    rememberMe:boolean=false;
    login: LoginData;


  constructor(private http:HttpClient) { }

  ngOnInit() { } 

  async loginbuttonClick() {
    const requestData:any={
      email:this.username,
      password:this.password
    }

   await this.http.post<LoginData>('https://localhost:44378/api/Default/Login',requestData ).subscribe(res => {
      this.login = res;
      console.log(this.login);
    });
    //if(this.login.message=="Success")

  }
}
export interface LoginData {
  code: string;
  message: string;
  data:any
}

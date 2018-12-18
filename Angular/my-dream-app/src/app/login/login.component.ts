import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { _getViewData } from '@angular/core/src/render3/instructions';
import {Router} from '@angular/router';


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
    errorMessage:string="";


  constructor(private http:HttpClient, private router: Router) { }

  ngOnInit() { } 

  async loginbuttonClick() {
    const requestData:any={
      email:this.username,
      password:this.password
    }

   await this.http.post<LoginData>('https://localhost:44378/api/Default/Login',requestData ).subscribe(res => {
      this.login = res;
      console.log(this.login);
      if(this.login.message=="Success"){
        this.router.navigateByUrl('/UserList');
      }
      else{
        this.errorMessage=this.login.message;
      }
  
    });
    
  }
}
export interface LoginData {
  code: string;
  message: string;
  data:any
}

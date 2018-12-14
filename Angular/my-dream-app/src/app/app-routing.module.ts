import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {LoginComponent} from "./login/login.component";
import { RouterModule, Routes } from '@angular/router';
import { ListUserComponent } from './list-user/list-user.component';

const route: Routes = [
  { path: 'login', component: LoginComponent },
  { path: '', component: LoginComponent },
  {path:'UserList', component:ListUserComponent}
];

//@NgModule({
 // declarations: [],
//  imports: [
 //   CommonModule,
 //   RouterModule.forRoot(routes)
 // ]
//})
//export class AppRoutingModule { }

export const routes = RouterModule.forRoot(route);

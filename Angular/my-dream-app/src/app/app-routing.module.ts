import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {LoginComponent} from "./login/login.component";
import { RouterModule, Routes } from '@angular/router';

const route: Routes = [
  { path: 'login', component: LoginComponent },
  { path: '', component: LoginComponent }
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

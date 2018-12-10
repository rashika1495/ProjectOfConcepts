import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AddUserComponent } from './add-user/add-user.component';
import { EditComponent } from './edit/edit.component';
import { ListUserComponent } from './list-user/list-user.component';
import { RouterModule, Routes } from '@angular/router';
import { routes } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AddUserComponent,
    EditComponent,
    ListUserComponent
  ],
  imports: [
    BrowserModule,
    routes
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }

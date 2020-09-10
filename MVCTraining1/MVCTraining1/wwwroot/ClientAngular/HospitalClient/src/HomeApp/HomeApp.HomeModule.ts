import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from "@angular/router";

import { HomeComponent } from './HomeApp.HomeComponent';
import { MasterComponent } from './HomeApp.MasterComponent';
import { IndexComponent } from "./HomeApp.IndexComponent";
import { LoginComponent } from "./HomeApp.LoginComponent";
import { HomeRoutes } from './HomeApp.Routing';
import { SecurityCheck } from "../Security/Security.Token";
import { AuthGuard } from 'src/Security/Security.AuthGuard';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    HomeComponent,
    MasterComponent,
    IndexComponent , 
    LoginComponent 
  ],
  imports: [
    BrowserModule ,
    FormsModule ,
    HttpClientModule ,
    RouterModule.forRoot(HomeRoutes),
    BrowserAnimationsModule ,
  ],
  providers: [SecurityCheck , AuthGuard],
  bootstrap: [IndexComponent]
})
export class HomeModule { }

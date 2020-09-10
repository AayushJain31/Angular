import { Component } from '@angular/core';
import { Router } from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './HomeApp.MasterPage.html',
  //styleUrls: ['./app.component.css']
})
export class MasterComponent {
  constructor(private router: Router) {}

  goHome(){
    this.router.navigate(['Home']); 
  }

  goPatient(){
    this.router.navigate(['Patient/Add']); 
  }

}

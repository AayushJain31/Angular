import { Component } from '@angular/core';
import { Patient,PatientProblems,Treatment } from "./PatientApp.PatientModel";
import { HttpClient } from "@angular/common/http";
import { from, of } from 'rxjs';
import { distinct, every } from 'rxjs/operators';
import { MatTableDataSource } from '@angular/material/table';
@Component({
  templateUrl: './PatientApp.PatientComponent.html',
  styleUrls: ['./PatientApp.PatientComponent.css']
})
export class PatientComponent {
  title = 'HospitalClient';
  patientObj:Patient = new Patient();
  patients:Array<Patient> = new Array<Patient>();
  problemObj:PatientProblems = new PatientProblems();
  treatmentObj:Treatment = new Treatment();

  displayedColumns: string[] = ['name' , 'number' , 'address' , 'email'];
  dataSource = null;

  constructor(public httpObj:HttpClient){

  }

  AddInMemory(){
    this.patients.push(this.patientObj);
    //this.dataSource.push(this.patients);
    this.patientObj = new Patient();
  }

  AddToDB(){
    var observable = this.httpObj.post("https://localhost:44376/api/PatientApi" , this.patients);
    console.log(this.patients);
    from(this.patients).pipe(distinct( pat => pat.name)).subscribe(pat => console.log(pat));
    observable.subscribe(res=>this.Success(res) , res=>this.Error(res));
  }
  Success(res){
    this.patients = res;
    // this.dataSource.push(this.patients);
    // this.dataSource = [...this.dataSource];
    console.log(this.dataSource);
  }
  Error(res){

  }

  getDataSource()
  {
    const ELEMENT_DATA : Patient[] = this.patients;
    this.dataSource = new MatTableDataSource<Patient>(ELEMENT_DATA);
    return this.dataSource;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  
}

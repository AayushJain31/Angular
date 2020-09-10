import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';

export class Patient{
    
    //formgroup:FormGroup = null;

    name:string = "";
    number:string = "";
    address:string = "";
    email:string = "";

    // constructor(){
    //     var _builder = new FormBuilder();
    //     this.formgroup = _builder.group({});
    //     this.formgroup.addControl("PatientNameControl" , new FormControl('',Validators.required));

    //     this.formgroup.addControl("PatientNumberControl" , new FormControl('' , Validators.pattern('^[0-9]{10}$')));

    //     var validationcollection = [];
    //     validationcollection.push(Validators.required);
    //     validationcollection.push(Validators.pattern('^[a-zA-Z0-9._]{1,12}@[a-z]{1,10}.[a-z]{1,3}$'));

    //     this.formgroup.addControl("EmailControl" , new FormControl('', Validators.compose(validationcollection)));
    // }

    problems:Array<PatientProblems> = new Array<PatientProblems>();
}

export class PatientProblems{
    problem:string = "";
    treatments:Array<Treatment> = new Array<Treatment>();
    constructor(){
        // this.problem = problem;
    }
}

export class Treatment{
    treatmentName:string = "";
    dose:string = "";
    constructor()
    {
        // this.treatmentName = treatmentName;
        // this.dose = dose;
    }
}
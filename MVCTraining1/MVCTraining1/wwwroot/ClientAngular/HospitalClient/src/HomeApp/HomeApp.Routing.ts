import { HomeComponent } from "./HomeApp.HomeComponent";
import { LoginComponent } from './HomeApp.LoginComponent';
import { MasterComponent } from './HomeApp.MasterComponent';
import { AuthGuard } from "../Security/Security.AuthGuard";
//import { PatientComponent } from "../PatientApp/PatientApp.PatientComponent";

export const HomeRoutes = [
    { path : 'Login' , component : LoginComponent},
    { path : '' , component : MasterComponent , canActivate : [AuthGuard] },
    { path : 'Master' , component : MasterComponent , canActivate : [AuthGuard] },
    { path : 'Home' , component : HomeComponent , canActivate : [AuthGuard] },
    { path : 'Patient' , loadChildren : () => import('../PatientApp/PatientApp.PatientModule')
                                        .then( m => m.PatientModule) , canActivate : [AuthGuard] }

]
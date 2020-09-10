import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from "rxjs";
import { SecurityCheck } from "./Security.Token";

@Injectable()
export class AuthGuard implements CanActivate{

    constructor( private _router: Router, public _token:SecurityCheck) { 

    }

    canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot):Observable<boolean>|Promise<boolean>|boolean{
        if(this._token.tokenValue.length != 0){  
            return true;
        }   
        this._router.navigate(['/Login']);

        return false;   
    }

   
}
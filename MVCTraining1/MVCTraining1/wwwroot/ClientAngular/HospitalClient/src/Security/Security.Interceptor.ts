import { Injectable } from "@angular/core";
import { HttpRequest , HttpHandler , HttpEvent , HttpInterceptor } from "@angular/common/http";
import { Observable } from "rxjs";
import { SecurityCheck } from "./Security.Token";

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    constructor(public security : SecurityCheck) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header with jwt token if available
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${this.security.tokenValue}`
                }
            });
        return next.handle(request);
    }
}
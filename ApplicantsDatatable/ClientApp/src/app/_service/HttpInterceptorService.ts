import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { finalize } from 'rxjs/operators';
import { SharedService } from './shared.service';


@Injectable()
export class HttpInterceptorService implements HttpInterceptor {
  private totalRequests = 0;
  constructor(private _SharedService: SharedService) { }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

   

    this.totalRequests++;
    this._SharedService.setLoading(true);

    
    return next.handle(req).pipe(
      finalize(() => {
        
          this.totalRequests--;
          if (this.totalRequests === 0) {

            this._SharedService.setLoading(false);

          }
        




      }



      ))
  }
}

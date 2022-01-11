import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class ApplicationService {
  constructor(private http: HttpClient) { }


  GetAllApplication() {
    return this.http.get(`/api/Application`)
      .pipe(map((data: any) => {
          return data;
        }),
        catchError((error: Error) => {
          return of({} as any);
        })
      );
  }



  AddApplication(data) {
    return this.http.post(`/api/Application`, data)
      .pipe(map((data: any) => {
        return data;
      }),
        catchError((error: Error) => {
          return of({} as any);
        })
      );
  }


  editeApplication(data) {
    return this.http.put(`/api/Application`, data)
      .pipe(map((data: any) => {
        return data;
      }),
        catchError((error: Error) => {
          return of({} as any);
        })
      );
  }

  GetApplicationbyId(data) {
    return this.http.get(`/api/Application/`+data)
      .pipe(map((data: any) => {
        return data;
      }),
        catchError((error: Error) => {
          return of({} as any);
        })
      );
  }

  deleteApplication(data) {
    return this.http.delete(`/api/Application/` + data)
      .pipe(map((data: any) => {
        return data;
      }),
        catchError((error: Error) => {
          return of({} as any);
        })
      );
  }
}

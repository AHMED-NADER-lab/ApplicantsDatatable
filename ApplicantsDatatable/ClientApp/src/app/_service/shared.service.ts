import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  showLoader = new Subject();
  constructor() { }

  setLoading(isLoading: boolean) {
    setTimeout(() => { this.showLoader.next(isLoading); })

  }
}

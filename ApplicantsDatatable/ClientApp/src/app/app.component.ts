import { Component, OnInit } from '@angular/core';
import { SharedService } from './_service/shared.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'app';
  isShow = false;
  constructor(public _SharedService: SharedService) { }
  ngOnInit() {

   

 
  }
}

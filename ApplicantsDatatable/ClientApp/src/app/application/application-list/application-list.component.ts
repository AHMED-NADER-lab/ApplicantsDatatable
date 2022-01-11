import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApplicationService } from '../../_service/application.service';

@Component({
  selector: 'app-application-list',
  templateUrl: './application-list.component.html',
  styleUrls: ['./application-list.component.css']
})
export class ApplicationListComponent implements OnInit {
  applicationlist: any[]=[]
  constructor(private _applicationService: ApplicationService,private router: Router) { }

  ngOnInit() {
    this.getApplication()
  }

  getApplication() {
    this._applicationService.GetAllApplication().subscribe(data => {
      this.applicationlist = data
    })
  }

  Edit(data) {
    this.router.navigate(['/application/add-edite'], { queryParams: { Id: data.Id } }); 

  }

  deletemodeldata(data) {
    if (confirm('Are you sure you want to delete this application?')) {
      // Save it!
      this._applicationService.deleteApplication(data.Id).subscribe(data => {
        if (data) {
          this.getApplication()
        }
      })
    } 
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, MinLengthValidator, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ApplicationService } from '../../_service/application.service';

@Component({
  selector: 'app-application-add-edite',
  templateUrl: './application-add-edite.component.html',
  styleUrls: ['./application-add-edite.component.css']
})
export class ApplicationAddEditeComponent implements OnInit {
  ApplicationFormGroup: FormGroup;
  constructor(private route: Router, private _applicationService: ApplicationService, private Activatedroute: ActivatedRoute,) { }

  ngOnInit() {

    const Id = this.Activatedroute.snapshot.queryParamMap.get('Id') || 0;;
   
    this.ApplicationFormGroup = new FormGroup({
      Id: new FormControl(""),
      Name: new FormControl("", [Validators.required, Validators.minLength(5)]),
      FamilyName: new FormControl("", [Validators.required, Validators.minLength(5)]),
      Address: new FormControl("", [Validators.required, Validators.minLength(10)]),
      Country: new FormControl("", Validators.required),
      EMail: new FormControl("", [Validators.required, Validators.email]),
      Age: new FormControl("", [Validators.required, Validators.min(20), Validators.max(60)]),
      Hired: new FormControl(false),


    })

    if (Id != 0) {
      this._applicationService.GetApplicationbyId(Id).subscribe(data => {
        this.ApplicationFormGroup.patchValue({
          Id: data.Id,
          Name: data.Name,
          FamilyName: data.FamilyName,
          Address: data.Address,
          Country: data.CountryOfOrigin,
          EMail: data.EMailAdress,
          Age: data.Age,
          Hired: data.Hired,
        })
      })
     
    }
  }


  onApplicationSubmitForm() {
    this.ApplicationFormGroup.markAllAsTouched();
    if (this.ApplicationFormGroup.valid) {
      const obj = {
        "Id": this.ApplicationFormGroup.value['Id'] ? this.ApplicationFormGroup.value['Id']:null,
        "Name": this.ApplicationFormGroup.value['Name'],
        "FamilyName": this.ApplicationFormGroup.value['FamilyName'],
        "Address": this.ApplicationFormGroup.value['Address'],
        "CountryOfOrigin": this.ApplicationFormGroup.value['Country'],
        "EMailAdress": this.ApplicationFormGroup.value['EMail'],
        "Age": this.ApplicationFormGroup.value['Age'],
        "Hired": this.ApplicationFormGroup.value['Hired'],
      }
      if (obj['Id']) {
        

        this._applicationService.editeApplication(obj).subscribe(data => {
          if (data) {
            this.route.navigate(['/application']);

          }
        })
      } else {
        this._applicationService.AddApplication(obj).subscribe(data => {
          if (data) {
            this.route.navigate(['/application']);

          }
        })
      }
    
    }

  }

}

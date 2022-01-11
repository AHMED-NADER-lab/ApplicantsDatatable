import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationListComponent } from './application-list/application-list.component';
import { ApplicationAddEditeComponent } from './application-add-edite/application-add-edite.component';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveFormsModule  } from '@angular/forms';

const routes: Routes = [
  { path: '', component: ApplicationListComponent },
  { path: 'add-edite', component: ApplicationAddEditeComponent },
 

]
@NgModule({
  declarations: [ApplicationListComponent, ApplicationAddEditeComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RouterModule.forChild(routes),
  ]
})
export class ApplicationModule { }

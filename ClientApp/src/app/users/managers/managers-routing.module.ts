import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CprofessorsComponent } from './cprofessors/cprofessors.component';

import { ManagersComponent } from './managers.component';

const routes: Routes = [
  { path: '', component: ManagersComponent,children:[
  { path:'cprofessors' , component: CprofessorsComponent },
]
 }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ManagersRoutingModule { }

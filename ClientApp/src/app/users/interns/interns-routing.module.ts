import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InternsComponent } from './interns.component';

const routes: Routes = [{ path: '', component: InternsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InternsRoutingModule { }

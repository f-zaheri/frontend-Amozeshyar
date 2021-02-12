import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InternsRoutingModule } from './interns-routing.module';
import { InternsComponent } from './interns.component';


@NgModule({
  declarations: [InternsComponent],
  imports: [
    CommonModule,
    InternsRoutingModule
  ]
})
export class InternsModule { }

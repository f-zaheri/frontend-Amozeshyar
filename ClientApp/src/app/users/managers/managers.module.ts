import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import { MatMenuModule } from '@angular/material/menu';
import { MatDialogModule } from '@angular/material/dialog';
import {MatTableModule} from '@angular/material/table';
import {MatToolbarModule} from '@angular/material/toolbar';


import { ManagersRoutingModule } from './managers-routing.module';
import { ManagersComponent } from './managers.component';
import { CprofessorsComponent } from './cprofessors/cprofessors.component';
import { AdddialogComponent } from './adddialog/adddialog.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [ManagersComponent, CprofessorsComponent, AdddialogComponent],
  imports: [
    CommonModule,
    ManagersRoutingModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatMenuModule,
    MatDialogModule,
    FormsModule,
    MatTableModule,
    MatToolbarModule
  ]
})
export class ManagersModule { }

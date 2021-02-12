import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatMenuModule} from '@angular/material/menu';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatTreeModule} from '@angular/material/tree';
import {MatListModule} from '@angular/material/list';
import {MatDialogModule} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';



import { UsersRoutingModule } from './users-routing.module';
import { UsersComponent } from './users.component';
import { NavbarComponent } from './common/navbar/navbar.component';
import { DashboardComponent } from './common/dashboard/dashboard.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { LayoutModule } from '@angular/cdk/layout';
import { PermissionDirective } from './common/permission.directive';
import { UsersBackendService } from './users-backend.service';


@NgModule({
  declarations: [UsersComponent, NavbarComponent, DashboardComponent, PermissionDirective],
  imports: [
    CommonModule,
    UsersRoutingModule,
    MatMenuModule,
    MatToolbarModule,
    MatGridListModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    LayoutModule,
    MatTreeModule,
    MatListModule,
    MatDialogModule,
    MatFormFieldModule
  ],
  providers:[
    UsersBackendService
  ]
})
export class UsersModule { }

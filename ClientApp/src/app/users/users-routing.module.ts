import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InternsGuard } from './interns.guard';
import { ManagersGuard } from './managers.guard';
import { ProfessorsGuard } from './professors.guard';

import { UsersComponent } from './users.component';

const routes: Routes = [
  { path: '', component: UsersComponent ,children:[
  { canLoad:[InternsGuard], path: 'interns', loadChildren: () => import('./interns/interns.module').then(m => m.InternsModule) },
  { canLoad:[ProfessorsGuard], path: 'professors', loadChildren: () => import('./professors/professors.module').then(m => m.ProfessorsModule) },
  {canLoad:[ManagersGuard],  path: 'managers', loadChildren: () => import('./managers/managers.module').then(m => m.ManagersModule) },
  ]},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsersRoutingModule { }

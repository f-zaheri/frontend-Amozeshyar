import { Component, OnInit} from '@angular/core';
import {MatDialog, } from '@angular/material/dialog';
import { UsersBackendService } from '../../users-backend.service';
import { AdddialogComponent } from '../adddialog/adddialog.component';


@Component({
  selector: 'app-cprofessors',
  templateUrl: './cprofessors.component.html',
  styleUrls: ['./cprofessors.component.scss']
})

export class CprofessorsComponent implements OnInit {
  current:any[];
  action:string='';

  constructor(public dialog: MatDialog,private backend:UsersBackendService) { }

  ngOnInit(): void {
  }

  openDialog(action): void {
    this.dialog.open(AdddialogComponent);
  }

//  openDialog(action):void {
  //  this.dialog.open(AdddialogComponent);
   // this.action=action;
   // switch (action) {
    //  case 'create':
    //    this.current={}
     //   break;

     // default:
     //   break;
   // }
  //}
}

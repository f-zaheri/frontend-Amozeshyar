import { Component, OnInit} from '@angular/core';
import {MatDialog, } from '@angular/material/dialog';
import { AdddialogComponent } from '../adddialog/adddialog.component';



@Component({
  selector: 'app-cprofessors',
  templateUrl: './cprofessors.component.html',
  styleUrls: ['./cprofessors.component.scss']
})
export class CprofessorsComponent implements OnInit {
  current:any;
  action:string='';
  data:any[];

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openDialog(action):void {
    this.dialog.open(AdddialogComponent);
    this.action=action;
    switch (action) {
      case 'create':
        this.current={}
        break;

      default:
        break;
    }
  }
}

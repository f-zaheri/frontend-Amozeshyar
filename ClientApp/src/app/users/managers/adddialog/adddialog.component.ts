import { Component, OnInit} from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { UsersBackendService } from '../../users-backend.service';


@Component({
  selector: 'app-adddialog',
  templateUrl: './adddialog.component.html',
  styleUrls: ['./adddialog.component.scss']
})
export class AdddialogComponent implements OnInit {
current: any;
action:string='';
data:any[];

  constructor(private backend:UsersBackendService,public dialod:MatDialog,public dialogRef: MatDialogRef<AdddialogComponent>) { }

  ngOnInit(): void {
    this.current={};
  }
  async ok(action){
    console.log(this.current);
    this.action=action;
    switch (action) {
      case 'create':
        try {
          await this.backend.post('/api/Professors',this.current);
          this.dialogRef.close();
        }
        catch {
        }

        break;

      default:
        break;
    }
  }
  async loadData(){
    this.data=await this.backend.get('/api/Professors') as any[];
  }
  
}

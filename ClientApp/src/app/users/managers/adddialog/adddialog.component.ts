import { Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import { UsersBackendService } from '../../users-backend.service';


@Component({
  selector: 'app-adddialog',
  templateUrl: './adddialog.component.html',
  styleUrls: ['./adddialog.component.scss']
})
export class AdddialogComponent implements OnInit {
current: any;
action:string;
data:any[];

  constructor(private backend:UsersBackendService) { }

  ngOnInit(): void {
    this.loadData();
  }
  async ok(){
    console.log(this.current);
    switch (this.action) {
      case 'create':
        try {
          await this.backend.post('/api/professors',this.current);
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
  cancel(){
  }
}

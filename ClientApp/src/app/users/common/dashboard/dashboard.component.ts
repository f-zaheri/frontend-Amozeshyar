import { Component } from '@angular/core';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  /** Based on the screen size, switch from standard to one column per row */
  cards = this.breakpointObserver.observe(Breakpoints.Handset).pipe(
    map(({ matches }) => {
      if (matches) {
        return [
          { title: 'مدیران', cols: 1, rows: 1 },
          { title: 'اساتید', cols: 1, rows: 2 },
          { title: 'کارآموزان', cols: 1, rows: 3 },
          { title: 'دروس', cols: 1, rows: 4 },
          { title: 'دوره ها', cols: 1, rows: 5 },
          { title: 'دوره های من', cols: 1, rows: 6 },
          { title: 'ارائه های من', cols: 1, rows: 7 }
        ];
      }

      return [
        { title: 'مدیران', cols: 1, rows: 1 },
        { title: 'اساتید', cols: 1, rows: 2 },
        { title: 'کارآموزان', cols: 1, rows: 3 },
        { title: 'دروس', cols: 1, rows: 4 },
        { title: 'دوره ها', cols: 1, rows: 5 },
        { title: 'دوره های من', cols: 1, rows: 6 },
        { title: 'ارائه های من', cols: 1, rows: 7 }
      ];
    })
  );

  constructor(private breakpointObserver: BreakpointObserver) {}
}

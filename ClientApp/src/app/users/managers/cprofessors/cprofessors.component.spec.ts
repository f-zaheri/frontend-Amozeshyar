import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CprofessorsComponent } from './cprofessors.component';

describe('CprofessorsComponent', () => {
  let component: CprofessorsComponent;
  let fixture: ComponentFixture<CprofessorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CprofessorsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CprofessorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { ProfessorsGuard } from './professors.guard';

describe('ProfessorsGuard', () => {
  let guard: ProfessorsGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(ProfessorsGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});

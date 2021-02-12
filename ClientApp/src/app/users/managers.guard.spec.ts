import { TestBed } from '@angular/core/testing';

import { ManagersGuard } from './managers.guard';

describe('ManagersGuard', () => {
  let guard: ManagersGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(ManagersGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { InternsGuard } from './interns.guard';

describe('InternsGuard', () => {
  let guard: InternsGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(InternsGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});

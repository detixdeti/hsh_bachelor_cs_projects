import { TestBed } from '@angular/core/testing';

import { BmiCalcService } from './bmi-calc.service';

describe('BmiCalcService', () => {
  let service: BmiCalcService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BmiCalcService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

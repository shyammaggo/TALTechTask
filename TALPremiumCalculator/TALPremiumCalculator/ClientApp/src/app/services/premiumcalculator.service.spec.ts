import { TestBed, inject } from '@angular/core/testing';

import { PremiumcalculatorService } from './premiumcalculator.service';

describe('PremiumcalculatorService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PremiumcalculatorService]
    });
  });

  it('should be created', inject([PremiumcalculatorService], (service: PremiumcalculatorService) => {
    expect(service).toBeTruthy();
  }));
});

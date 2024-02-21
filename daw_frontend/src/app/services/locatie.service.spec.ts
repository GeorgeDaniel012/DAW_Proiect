import { TestBed } from '@angular/core/testing';

import { LocatieService } from './locatie.service';

describe('LocatieService', () => {
  let service: LocatieService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LocatieService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

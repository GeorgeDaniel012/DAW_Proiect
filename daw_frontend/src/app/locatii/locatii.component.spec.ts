import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LocatiiComponent } from './locatii.component';

describe('LocatiiComponent', () => {
  let component: LocatiiComponent;
  let fixture: ComponentFixture<LocatiiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LocatiiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LocatiiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

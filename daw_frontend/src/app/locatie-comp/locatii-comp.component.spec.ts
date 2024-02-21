import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LocatieCompComponent } from './locatii-comp.component';

describe('LocatieCompComponent', () => {
  let component: LocatieCompComponent;
  let fixture: ComponentFixture<LocatieCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LocatieCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LocatieCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

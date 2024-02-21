import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RetetaCompComponent } from './reteta-comp.component';

describe('RetetaCompComponent', () => {
  let component: RetetaCompComponent;
  let fixture: ComponentFixture<RetetaCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RetetaCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RetetaCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

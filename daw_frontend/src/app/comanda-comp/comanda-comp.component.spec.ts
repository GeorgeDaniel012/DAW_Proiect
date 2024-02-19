import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComandaCompComponent } from './comanda-comp.component';

describe('ComandaCompComponent', () => {
  let component: ComandaCompComponent;
  let fixture: ComponentFixture<ComandaCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComandaCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComandaCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

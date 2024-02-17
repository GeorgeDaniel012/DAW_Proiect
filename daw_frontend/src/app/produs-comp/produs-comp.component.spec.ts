import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdusCompComponent } from './produs-comp.component';

describe('ProdusCompComponent', () => {
  let component: ProdusCompComponent;
  let fixture: ComponentFixture<ProdusCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdusCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProdusCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

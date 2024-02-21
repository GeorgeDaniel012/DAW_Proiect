import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecenzieCompComponent } from './recenzie-comp.component';

describe('RecenzieCompComponent', () => {
  let component: RecenzieCompComponent;
  let fixture: ComponentFixture<RecenzieCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecenzieCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RecenzieCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

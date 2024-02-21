import { Component, Input } from '@angular/core';
import { Reteta } from '../entities/reteta';

@Component({
  selector: 'app-reteta-comp',
  standalone: true,
  imports: [],
  templateUrl: './reteta-comp.component.html',
  styleUrl: './reteta-comp.component.css'
})
export class RetetaCompComponent {
  @Input() public reteta: Reteta = {
    produsId: 0,
    indicatii: "nume produs"
  };
}

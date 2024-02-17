import { Component, Input } from '@angular/core';
import { Produs } from '../produs';

@Component({
  selector: 'app-produs-comp',
  standalone: true,
  imports: [],
  templateUrl: './produs-comp.component.html',
  styleUrl: './produs-comp.component.css'
})
export class ProdusCompComponent {
  @Input() public produs: Produs = {
    id: 0,
    denumire: "nume produs",
    descriere: "descriere produs",
    categorieId: 0
  };
}

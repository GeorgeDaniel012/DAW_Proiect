import { Component, Input } from '@angular/core';
import { Locatie } from '../entities/locatie';

@Component({
  selector: 'app-locatie-comp',
  standalone: true,
  imports: [],
  templateUrl: './locatii-comp.component.html',
  styleUrl: './locatii-comp.component.css'
})
export class LocatieCompComponent {
  @Input() public locatie: Locatie = {
    id: 0,
    oras: "nume oras",
    strada: "nume strada",
    numar_cladire: 1
  };
}

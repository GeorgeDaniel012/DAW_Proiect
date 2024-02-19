import { Component, Input, OnInit } from '@angular/core';
import { Produs } from '../entities/produs';

@Component({
  selector: 'app-produs-comp',
  standalone: true,
  imports: [],
  templateUrl: './produs-comp.component.html',
  styleUrl: './produs-comp.component.css'
})
export class ProdusCompComponent implements OnInit {
  @Input() public produs: Produs = {
    id: 0,
    denumire: "nume produs",
    descriere: "descriere produs",
    categorieId: 0
  };

  ngOnInit(): void {
    //console.log(this.produs);
  }
}

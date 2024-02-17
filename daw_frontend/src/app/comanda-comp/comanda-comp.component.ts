import { Component, Input, OnInit } from '@angular/core';
import { Comanda } from '../comanda';
import { ProdusCompComponent } from "../produs-comp/produs-comp.component";
import { NgForOf } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-comanda-comp',
    standalone: true,
    templateUrl: './comanda-comp.component.html',
    styleUrl: './comanda-comp.component.css',
    imports: [
      RouterLink,
      NgForOf,
      ProdusCompComponent
    ]
})
export class ComandaCompComponent implements OnInit {
  data: Date = new Date("Sat Feb 17 2024 22:28:57 GMT+0200 (Eastern European Standard Time)");

  @Input() public comanda: Comanda = {
    id: 0,
    produse: [],
    clientId: 0,
    dataComanda: this.data
  };

  ngOnInit(): void{
    this.comanda.produse.forEach(prod => console.log(prod));
    //console.log(this.comanda);
  }
}

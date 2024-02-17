import { Component } from '@angular/core';
import { ProdusService } from '../produs.service';
import { take } from 'rxjs';
import { Produs } from '../produs';
import { ProdusCompComponent } from "../produs-comp/produs-comp.component";
import { RouterLink } from '@angular/router';
import { NgForOf } from '@angular/common';

@Component({
    selector: 'app-produse',
    standalone: true,
    templateUrl: './produse.component.html',
    styleUrl: './produse.component.css',
    imports: [
      RouterLink,
      NgForOf,
      ProdusCompComponent
    ]
})
export class ProduseComponent {
  constructor(private produsService: ProdusService){}

  produse: any[] = [];
  ngOnInit(): void {
    this.produsService.getProduse().pipe(take(1)).subscribe(
      (x: any) => {
        this.produse = x;
      });
    // this.produsService.getProduse().subscribe(x => {
    //   this.produse = x;
    // });
  }
}

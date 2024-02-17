import { Component } from '@angular/core';
import { ComandaService } from '../comanda.service';
import { take } from 'rxjs';
import { ComandaCompComponent } from "../comanda-comp/comanda-comp.component";
import { RouterLink } from '@angular/router';
import { NgForOf } from '@angular/common';

@Component({
    selector: 'app-comenzi',
    standalone: true,
    templateUrl: './comenzi.component.html',
    styleUrl: './comenzi.component.css',
    imports: [
      RouterLink,
      NgForOf,
      ComandaCompComponent
    ]
})
export class ComenziComponent {
  constructor(private comandaService: ComandaService){}

  comenzi: any[] = [];
  ngOnInit(): void {
    this.comandaService.getComenzi().pipe(take(1)).subscribe(
      (x: any) => {
        this.comenzi = x;
      });
  }
}

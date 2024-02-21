import { Component } from '@angular/core';
import { ReteteService } from '../services/retete.service';
import { take } from 'rxjs';
import { RouterLink } from '@angular/router';
import { NgForOf } from '@angular/common';
import { RetetaCompComponent } from '../reteta-comp/reteta-comp.component';

@Component({
  selector: 'app-retete',
  standalone: true,
  imports: [
    RouterLink,
    NgForOf,
    RetetaCompComponent
  ],
  templateUrl: './retete.component.html',
  styleUrl: './retete.component.css'
})
export class ReteteComponent {
  constructor(private retetaService: ReteteService){}

  retete: any[] = [];
  ngOnInit(): void {
    this.retetaService.getReteta().pipe(take(1)).subscribe(
      (x: any) => {
        this.retete = x;
      });
  }
}

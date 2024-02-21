import { Component } from '@angular/core';
import { RecenziiService } from '../services/recenzii.service';
import { take } from 'rxjs';
import { RecenzieCompComponent } from "../recenzie-comp/recenzie-comp.component";
import { RouterLink } from '@angular/router';
import { NgForOf } from '@angular/common';


@Component({
  selector: 'app-recenzii',
  standalone: true,
  imports: [
    RouterLink,
    NgForOf,
    RecenzieCompComponent
  ],
  templateUrl: './recenzii.component.html',
  styleUrl: './recenzii.component.css'
})
export class RecenziiComponent {
  constructor(private recenzieService: RecenziiService){}

  recenzii: any[] = [];
  ngOnInit(): void {
    this.recenzieService.getRecenzii().pipe(take(1)).subscribe(
      (x: any) => {
        this.recenzii = x;
      });
  }
}

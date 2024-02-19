import { Component } from '@angular/core';
import { LocatieService } from '../services/locatie.service';
import { take } from 'rxjs';
import { LocatieCompComponent } from "../locatie-comp/locatii-comp.component";
import { NgForOf } from '@angular/common';
import { RouterLink } from '@angular/router';


@Component({
    selector: 'app-locatie',
    standalone: true,
    templateUrl: './locatie.component.html',
    styleUrl: './locatie.component.css',
    imports: [
      RouterLink,
      NgForOf,
      LocatieCompComponent
    ]
})
export class LocatieComponent {
  constructor(private locatieService: LocatieService){}
  locatie: any[] = [];
  ngOnInit(): void {
    this.locatieService.getLocatie().pipe(take(1)).subscribe(
      (x: any) => {
        this.locatie = x;
      });
    
  }
  
}


import { Component } from '@angular/core';
import { LocatieService } from '../services/locatie.service';
import { take } from 'rxjs';
import { LocatieCompComponent } from "../locatie-comp/locatii-comp.component";
import { NgForOf } from '@angular/common';
import { RouterLink } from '@angular/router';


@Component({
    selector: 'app-locatie',
    standalone: true,
    templateUrl: './locatii.component.html',
    styleUrl: './locatii.component.css',
    imports: [
      RouterLink,
      NgForOf,
      LocatieCompComponent
    ]
})
export class LocatieComponent {
  constructor(private locatieService: LocatieService){}
  locatii: any[] = [];
  ngOnInit(): void {
    this.locatieService.getLocatie().pipe(take(1)).subscribe(
      (x: any) => {
        this.locatii = x;
      });
    
  }
  
}


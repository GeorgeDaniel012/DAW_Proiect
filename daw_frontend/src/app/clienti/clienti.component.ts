import { Component } from '@angular/core';
import { ClientService } from '../services/client.service';
import { take } from 'rxjs';
import { ClientCompComponent } from "../client-comp/client-comp.component";
import { NgForOf } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-clienti',
    standalone: true,
    templateUrl: './clienti.component.html',
    styleUrl: './clienti.component.css',
    imports: [
      RouterLink,
      NgForOf,
      ClientCompComponent
    ]
})
export class ClientiComponent {
  constructor(private clientService: ClientService){}

  clienti: any[] = [];
  ngOnInit(): void {
    this.clientService.getClienti().pipe(take(1)).subscribe(
      (x: any) => {
        this.clienti = x;
      });
  }
}

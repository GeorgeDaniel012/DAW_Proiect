import { Component, Input } from '@angular/core';
import { Client } from '../entities/client';

@Component({
  selector: 'app-client-comp',
  standalone: true,
  imports: [],
  templateUrl: './client-comp.component.html',
  styleUrl: './client-comp.component.css'
})
export class ClientCompComponent {
  @Input() public client: Client = {
    id: 0,
    nume: "nume client",
    prenume: "prenume client",
    email: "email@email.com"
  };
}

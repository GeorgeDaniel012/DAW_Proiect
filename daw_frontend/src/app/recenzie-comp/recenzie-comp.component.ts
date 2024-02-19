import { Component, Input, OnInit } from '@angular/core';
import {Recenzie} from '../entities/recenzie';

@Component({
  selector: 'app-recenzie-comp',
  standalone: true,
  imports: [],
  templateUrl: './recenzie-comp.component.html',
  styleUrl: './recenzie-comp.component.css'
})
export class RecenzieCompComponent implements OnInit {
  @Input() public recenzie: Recenzie = {
    id: 0,
    nota: 0,
    comentariu: "coment",
    produsId: 0,
    clientId: 0
  };

  ngOnInit(): void {
    console.log(this.recenzie);
  }
}

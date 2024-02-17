import { Component } from '@angular/core';
import { take } from 'rxjs';
import { UserService } from '../user.service';

@Component({
  selector: 'app-utilizatori',
  standalone: true,
  imports: [],
  templateUrl: './utilizatori.component.html',
  styleUrl: './utilizatori.component.css'
})
export class UtilizatoriComponent {
  constructor(private service: UserService){}
  public getUsers(): void {
    this.service.getAuthUsers().pipe(take(1)).subscribe((val: any) => console.log(val));
  }
}

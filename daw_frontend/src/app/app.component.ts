import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginComponent } from './login/login.component';
import { UserService } from './services/user.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, NavbarComponent, LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  constructor(private userService: UserService) {}
  ngOnInit(): void{
    this.userService.getUsers().subscribe((x: any) => console.log(x));
  }
  
  title = 'daw_frontend';
  //public titlu: string = 'Acesta este portalul meu de stiri bun!';

  public search(nume: string): void {
    alert(nume);
  }
}

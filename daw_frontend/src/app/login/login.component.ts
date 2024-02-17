import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../user.service';
import { take } from 'rxjs/internal/operators/take';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  constructor(private userService: UserService) {}
  public loginGroup: FormGroup = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  public submit() {
    if(this.loginGroup.valid){
      this.userService.login(this.loginGroup.value).pipe(take(1)).subscribe((userData) => {
        console.log(this.loginGroup);
        localStorage.setItem('token', userData.token);
      });
    }
  }
}

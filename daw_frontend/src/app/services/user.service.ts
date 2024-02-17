import { Injectable } from '@angular/core';
import { HttpBackend, HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { User } from '../entities/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http:HttpClient) { }
  public getUrl: string = "https://localhost:7155/Users";
  public postUrl: string = "https://localhost:7155/Users";

  public hello(): void {
    alert("Hello!");
  }

  public getUsers(): Observable<any> {
    //return this.http.get(this.getUrl);
    return this.http.get<any>(this.getUrl);//.pipe(map((resp) => resp.data))
  }

  public login(user: any): Observable<any> {
    return this.http.post<any>('http://localhost:4200/users/authenticate', user);
  }

  public getAuthUsers(): Observable<any> {
    return this.http.get<any>('http://localhost:4200/users', {
      headers: {Authorization: `Bearer ${localStorage.getItem('token')}`}
    })
  }

}

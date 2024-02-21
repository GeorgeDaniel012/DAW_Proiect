import { Injectable } from '@angular/core';
import { HttpBackend, HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { Reteta } from '../entities/reteta';

@Injectable({
  providedIn: 'root'
})
export class ReteteService {
  constructor(private http:HttpClient) { }
  public getUrl: string = "https://localhost:7155/api/Reteta";
  public postUrl: string = "https://localhost:7155/api/Reteta";


  public getReteta(): Observable<any> {
    //return this.http.get(this.getUrl);
    return this.http.get<any>(this.getUrl);//.pipe(map((resp) => resp.data))
  }

}

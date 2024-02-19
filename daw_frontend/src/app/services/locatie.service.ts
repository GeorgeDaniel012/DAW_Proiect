import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Locatie} from '../entities/locatie';

@Injectable({
  providedIn: 'root'
})
export class LocatieService {
  constructor(private http:HttpClient) { }
  public getUrl: string = "https://localhost:7155/api/Locatie";
  public postUrl: string = "https://localhost:7155/api/Locatie";

  public getLocatie(): Observable<any> {
    //return this.http.get(this.getUrl);
    return this.http.get<any>(this.getUrl);//.pipe(map((resp) => resp.data))
  }
}

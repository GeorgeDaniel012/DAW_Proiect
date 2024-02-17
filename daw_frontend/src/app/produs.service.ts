import { Injectable } from '@angular/core';
import { HttpBackend, HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { Produs } from './produs';

@Injectable({
  providedIn: 'root'
})
export class ProdusService {
  constructor(private http:HttpClient) { }
  public getUrl: string = "https://localhost:7155/api/Produs";
  public postUrl: string = "https://localhost:7155/api/Produs";

  public hello(): void {
    alert("Hello!");
  }

  public getProduse(): Observable<any> {
    //return this.http.get(this.getUrl);
    return this.http.get<any>(this.getUrl);//.pipe(map((resp) => resp.data))
  }

  public addProdus(produs: Produs): Observable<any> {
    return this.http.post<any>(this.postUrl, produs);
  }
}

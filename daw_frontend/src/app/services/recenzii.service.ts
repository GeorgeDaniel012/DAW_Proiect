import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecenziiService {

  constructor(private http:HttpClient) { }
  public getUrl: string = "https://localhost:7155/api/Recenzie";
  public postUrl: string = "https://localhost:7155/api/Recenzie";

  public getRecenzii(): Observable<any> {
    //return this.http.get(this.getUrl);
    return this.http.get<any>(this.getUrl);//.pipe(map((resp) => resp.data))
  }
}

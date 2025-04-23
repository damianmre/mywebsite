import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Woord } from '../models/woord';

@Injectable({
  providedIn: 'root'
})
export class WoordenschatService {
  private apiUrl = 'http://localhost:5151/api/Woorden/getwoorden';

  constructor(private http: HttpClient) {}

  getWoorden(): Observable<Woord[]> {
    return this.http.get<Woord[]>(this.apiUrl);
  }
}

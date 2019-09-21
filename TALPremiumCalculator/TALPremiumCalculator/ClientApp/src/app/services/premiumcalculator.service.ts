 
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { occupationList }from '../../models/premiumcalc';

@Injectable({
  providedIn: 'root'
})
export class PremiumcalculatorService {
  headers: HttpHeaders;
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'content-type': 'application/json' });
  }  
  GetOccupationList(): Observable<occupationList[]> {
    return this.http.get<occupationList[]>(environment.apiAddress + '/api/GetOccupationList/GetOccupation');
  }
}

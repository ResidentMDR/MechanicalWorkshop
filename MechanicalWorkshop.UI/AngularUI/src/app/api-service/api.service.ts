import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICustomer } from 'src/app/interfaces/icustomer'
import { IRepair } from '../interfaces/irepair';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class APIService {
  apiUrl: string = environment.apiUrl;
  subscriptionKey: string = '424bbda15e0a46cb8903c435ac21cf6f';
  headers = new HttpHeaders({ 'Ocp-Apim-Subscription-Key': this.subscriptionKey });

  constructor(private httpClient: HttpClient) { }

  getAllCustomers(): Observable<ICustomer[]> {
    return this.httpClient.get<ICustomer[]>(`${this.apiUrl}/v1/Customer/customers`, { headers: this.headers });
  }

  getAllRepairs(): Observable<IRepair[]> {
    return this.httpClient.get<IRepair[]>(`${this.apiUrl}/v1/Repair/Repairs`, { headers: this.headers });
  }
}

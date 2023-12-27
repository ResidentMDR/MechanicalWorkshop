import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICustomer } from 'src/app/interfaces/icustomer'

@Injectable({
  providedIn: 'root'
})
export class APIService {

  constructor(private httpClient: HttpClient) { }

  getAllCustomers(): Observable<ICustomer[]> {
    return this.httpClient.get<ICustomer[]>('https://localhost:7037/api/v1/Customer/customers');
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerEntity } from 'src/app/models/customer.model';

@Injectable({
  providedIn: 'root'
})
export class APIService {

  constructor(private httpClient: HttpClient) { }

  getAllCustomers(): Observable<CustomerEntity[]> {
    return this.httpClient.get<CustomerEntity[]>('api/v1/customers');
  }
}

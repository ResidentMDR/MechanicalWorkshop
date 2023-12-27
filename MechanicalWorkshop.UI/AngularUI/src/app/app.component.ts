import { Component, OnInit } from '@angular/core';
import { APIService } from './components/api-service/api.service';
import { ICustomer } from './interfaces/icustomer';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  customers: ICustomer[] = [];
  title = 'Mechanical Workshop';

  constructor(private apiService: APIService) {}

  ngOnInit(): void {
    this.apiService.getAllCustomers().subscribe(
      (data: ICustomer[]) => {
        this.customers = data;
      },
    );
  }
}

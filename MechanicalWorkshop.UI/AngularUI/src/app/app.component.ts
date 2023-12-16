import { Component, OnInit } from '@angular/core';
import { APIService } from './components/api-service/api.service';
import { CustomerEntity } from './models/customer.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  customers: CustomerEntity[] = [];
  title = 'Mechanical Workshop';

  constructor(private apiService: APIService) {}

  ngOnInit(): void {
    this.apiService.getAllCustomers().subscribe(
      (data: CustomerEntity[]) => {
        this.customers = data;
      },
      (error) => {
        console.error('Error fetching customers:', error);
      }
    );
  }
}

import { Component, OnInit } from '@angular/core';
import { TopNavbarComponent } from '../../../components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from '../../../components/left-navbar/left-navbar.component';
import { ContentViewComponent } from '../../../components/content-view/content-view.component';
import { APIService } from '../../../components/api-service/api.service';
import { ICustomer } from '../../../interfaces/icustomer';

@Component({
  selector: 'app-customers-view',
  standalone: true,
  imports: [
    TopNavbarComponent,
    LeftNavbarComponent,
    ContentViewComponent
  ],
  templateUrl: './customers-view.component.html',
  styleUrl: './customers-view.component.scss'
})
export class CustomersViewComponent implements OnInit {
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
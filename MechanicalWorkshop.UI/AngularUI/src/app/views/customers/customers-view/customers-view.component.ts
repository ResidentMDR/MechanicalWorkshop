import { Component, OnInit } from '@angular/core';
import { TopNavbarComponent } from '../../../components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from '../../../components/left-navbar/left-navbar.component';
import { APIService } from '../../../api-service/api.service';
import { ICustomer } from '../../../interfaces/icustomer';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-customers-view',
  standalone: true,
  imports: [
    TopNavbarComponent,
    LeftNavbarComponent,
    CommonModule,
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
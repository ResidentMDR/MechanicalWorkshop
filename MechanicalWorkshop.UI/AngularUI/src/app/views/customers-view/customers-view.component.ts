import { Component, OnInit } from '@angular/core';
import { TopNavbarComponent } from '../../components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from '../../components/left-navbar/left-navbar.component';
import { APIService } from '../../api-service/api.service';
import { ICustomer } from '../../interfaces/icustomer';
import { CommonModule } from '@angular/common';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@Component({
  selector: 'app-customers-view',
  standalone: true,
  imports: [
    TopNavbarComponent,
    LeftNavbarComponent,
    CommonModule,
    ReactiveFormsModule,
    MatProgressSpinnerModule,
  ],
  templateUrl: './customers-view.component.html',
  styleUrl: './customers-view.component.scss'
})
export class CustomersViewComponent implements OnInit {
  customers: ICustomer[] = [];
  name = new FormControl('');
  lastName = new FormControl('');
  showLoader = true;

  constructor(private apiService: APIService) {}

  ngOnInit(): void {
    this.apiService.getAllCustomers().subscribe(
      (data: ICustomer[]) => {
        this.customers = data;
        this.showLoader = false;
      },
    );
  }
}
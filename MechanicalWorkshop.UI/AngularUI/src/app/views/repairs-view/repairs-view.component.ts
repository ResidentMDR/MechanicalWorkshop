import { CommonModule } from '@angular/common';

import { Component, OnInit } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { APIService } from 'src/app/api-service/api.service';
import { IRepair } from 'src/app/interfaces/irepair';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';


@Component({
  selector: 'app-repairs-view',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatProgressSpinnerModule,
  ],
  templateUrl: './repairs-view.component.html',
  styleUrl: './repairs-view.component.scss'
})
export class RepairsViewComponent implements OnInit {
  customer = new FormControl('');
  car = new FormControl('');
  mechanic = new FormControl('');
  description = new FormControl('');
  price = new FormControl('');
  repairs: IRepair[] = [];
  showLoader = true;

  constructor(private apiService: APIService) {}

  ngOnInit(): void {
    this.apiService.getAllRepairs().subscribe(
      (data: IRepair[]) => {
        this.repairs = this.formatDates(data);
        this.showLoader = false;
      }
    );
  }

  private formatDates(data: IRepair[]): IRepair[] {
    return data.map((repair: IRepair) => {
      if (repair.registrationDate) {
        repair.registrationDate = repair.registrationDate.split('T')[0];
      }
      return repair;
    });
  }
}

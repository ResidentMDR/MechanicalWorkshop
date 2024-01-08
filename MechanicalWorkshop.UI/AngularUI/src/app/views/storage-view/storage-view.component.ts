import { CommonModule } from '@angular/common';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

import { Component, OnInit } from '@angular/core';
import { APIService } from 'src/app/api-service/api.service';
import { IStorageItem } from 'src/app/interfaces/istorage-item';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-storage-view',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatProgressSpinnerModule,
  ],
  templateUrl: './storage-view.component.html',
  styleUrl: './storage-view.component.scss'
})
export class StorageViewComponent implements OnInit {
  name = new FormControl('');
  quantity = new FormControl('');
  pricePerUnit = new FormControl('');
  storageItems: IStorageItem[] = [];
  showLoader = true;

  constructor(private apiService: APIService ) {}

  ngOnInit(): void {
    this.apiService.getAllStorageItems().subscribe(
      (data: IStorageItem[]) => {
        this.storageItems = data;
        this.showLoader = false;
      }
    );
  }
}

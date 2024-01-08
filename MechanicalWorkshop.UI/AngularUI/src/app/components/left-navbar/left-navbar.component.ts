import { Component } from '@angular/core';

import { MatDialog } from '@angular/material/dialog';
import { DialogDataExampleDialogComponent } from '../dialog-data-example-dialog/dialog-data-example-dialog.component';

@Component({
  selector: 'app-left-navbar',
  standalone: true,
  templateUrl: './left-navbar.component.html',
  styleUrls: ['./left-navbar.component.scss']
})
export class LeftNavbarComponent {

  constructor(public dialog: MatDialog) {}

  openDialog() {
    this.dialog.open(DialogDataExampleDialogComponent, {
    });
  }
}

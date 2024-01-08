import {Component, Inject} from '@angular/core';
import {
  MatDialog,
  MAT_DIALOG_DATA,
  MatDialogRef,
  MatDialogTitle,
  MatDialogContent,
  MatDialogActions,
  MatDialogClose,
} from '@angular/material/dialog';
import {MatButtonModule} from '@angular/material/button';

export interface DialogData {
  animal: 'panda' | 'unicorn' | 'lion';
}

/**
 * @title Injecting data when opening a dialog
 */
@Component({
  selector: 'dialog-data-example',
  templateUrl: './dialog-data-example.component.html',
  standalone: true,
  imports: [MatButtonModule],
})
export class DialogDataExample {
  constructor(public dialog: MatDialog) {}

  openDialog() {
    this.dialog.open(DialogDataExampleDialogComponent, {
    });
  }

  // onNoClick(): void {
  //   this.dialogRef.close();
  // }
}

@Component({
  selector: 'app-dialog-data-example-dialog',
  standalone: true,
  imports: [MatDialogTitle, MatDialogContent],
  templateUrl: './dialog-data-example-dialog.component.html',
  styleUrl: './dialog-data-example-dialog.component.scss'
})
export class DialogDataExampleDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<DialogDataExampleDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
  ) {}

  onNoClick(): void {
    this.dialogRef.close();
  }
}

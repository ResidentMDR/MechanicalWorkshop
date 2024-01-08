import { Component } from '@angular/core';
import { TopNavbarComponent } from '../../components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from '../../components/left-navbar/left-navbar.component';

@Component({
  selector: 'app-home-view',
  standalone: true,
  imports: [
    TopNavbarComponent,
    LeftNavbarComponent,
  ],
  templateUrl: './home-view.component.html',
  styleUrl: './home-view.component.scss'
})

export class HomeViewComponent {
  downloadPdf(): void {
    const pdfPath = '../../../assets/SamplePdf.pdf';
    const link = document.createElement('a');
    link.href = pdfPath;
    link.download = 'SamplePdf.pdf';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
  }
}

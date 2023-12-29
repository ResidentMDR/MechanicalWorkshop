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

}

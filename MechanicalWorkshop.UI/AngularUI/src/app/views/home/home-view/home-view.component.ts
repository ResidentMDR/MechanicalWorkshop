import { Component } from '@angular/core';
import { TopNavbarComponent } from '../../../components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from '../../../components/left-navbar/left-navbar.component';
import { ContentViewComponent } from '../../../components/content-view/content-view.component';

@Component({
  selector: 'app-home-view',
  standalone: true,
  imports: [
    TopNavbarComponent,
    LeftNavbarComponent,
    ContentViewComponent
  ],
  templateUrl: './home-view.component.html',
  styleUrl: './home-view.component.scss'
})

export class HomeViewComponent {

}

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeViewComponent } from './views/home-view/home-view.component';
import { CustomersViewComponent } from './views/customers-view/customers-view.component';
import { RepairsViewComponent } from './views/repairs-view/repairs-view.component';
import { TopNavbarComponent } from './components/top-navbar/top-navbar.component';

const routes: Routes = [
  { path: '', component: HomeViewComponent, title: 'Home View Page' },
  { path: 'home', component: HomeViewComponent },
  { path: 'customers', component: CustomersViewComponent },
  { path: 'repairs', component: RepairsViewComponent },
  { path: 'navbar', component: TopNavbarComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

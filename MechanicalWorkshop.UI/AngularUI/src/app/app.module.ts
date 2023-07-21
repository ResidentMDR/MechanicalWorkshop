import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopNavbarComponent } from './components/top-navbar/top-navbar.component';
import { LeftNavbarComponent } from './components/left-navbar/left-navbar.component';
import { ContentViewComponent } from './components/content-view/content-view.component';

@NgModule({
  declarations: [
    AppComponent,
    TopNavbarComponent,
    LeftNavbarComponent,
    ContentViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

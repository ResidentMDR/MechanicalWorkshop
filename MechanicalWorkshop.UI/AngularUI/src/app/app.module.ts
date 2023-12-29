import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeViewComponent } from './views/home-view/home-view.component';
import { TopNavbarComponent } from "./components/top-navbar/top-navbar.component";
import { LeftNavbarComponent } from "./components/left-navbar/left-navbar.component";
import { ContentViewComponent } from "./components/content-view/content-view.component";
import { HeaderComponent } from './components/header/header.component';

@NgModule({
    declarations: [
        AppComponent,
    ],
    providers: [
        HttpClientModule,
    ],
    bootstrap: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        RouterModule,
        HttpClientModule,
        HeaderComponent,
        TopNavbarComponent,
        LeftNavbarComponent,
        ContentViewComponent
    ]
})
export class AppModule { }

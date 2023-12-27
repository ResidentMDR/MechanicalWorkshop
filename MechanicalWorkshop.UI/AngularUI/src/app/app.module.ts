import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeViewComponent } from './views/home/home-view/home-view.component';
import { RouterModule } from '@angular/router';
import { TopNavbarComponent } from "./components/top-navbar/top-navbar.component";
import { LeftNavbarComponent } from "./components/left-navbar/left-navbar.component";
import { ContentViewComponent } from "./components/content-view/content-view.component";

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
        HomeViewComponent,
        TopNavbarComponent,
        LeftNavbarComponent,
        ContentViewComponent
    ]
})
export class AppModule { }

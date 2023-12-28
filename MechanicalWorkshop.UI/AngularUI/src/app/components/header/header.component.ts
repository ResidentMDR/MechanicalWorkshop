import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  pageTitle: string = 'Default Title';

  constructor(private router: Router) {}

  ngOnInit(): void {
    this.router.events
      .pipe(filter(event => event instanceof NavigationEnd))
      .subscribe((event: any) => {
        if (event instanceof NavigationEnd) {
          this.updateTitle(event.url);
        }
      });
  }

  private updateTitle(url: string): void {
    const parts = url.split('/');
    const lastPart = parts[parts.length - 1];
    
    const title = this.convertToTitleCase(lastPart);

    this.pageTitle = title;
  }

  private convertToTitleCase(str: string): string {
    return str.replace(/\b\w/g, firstChar => firstChar.toUpperCase());
  }
}

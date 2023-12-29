import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RepairsViewComponent } from './repairs-view.component';

describe('RepairsViewComponent', () => {
  let component: RepairsViewComponent;
  let fixture: ComponentFixture<RepairsViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RepairsViewComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RepairsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderSliderIconComponent } from './header-slider-icon.component';

describe('HeaderSliderIconComponent', () => {
  let component: HeaderSliderIconComponent;
  let fixture: ComponentFixture<HeaderSliderIconComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HeaderSliderIconComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HeaderSliderIconComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

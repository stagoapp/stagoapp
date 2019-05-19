import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SignInNavbarComponent } from './sign-in-navbar.component';

describe('SignInNavbarComponent', () => {
  let component: SignInNavbarComponent;
  let fixture: ComponentFixture<SignInNavbarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SignInNavbarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SignInNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

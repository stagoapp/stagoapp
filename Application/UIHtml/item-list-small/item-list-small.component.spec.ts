import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemListSmallComponent } from './item-list-small.component';

describe('ItemListSmallComponent', () => {
  let component: ItemListSmallComponent;
  let fixture: ComponentFixture<ItemListSmallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ItemListSmallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemListSmallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

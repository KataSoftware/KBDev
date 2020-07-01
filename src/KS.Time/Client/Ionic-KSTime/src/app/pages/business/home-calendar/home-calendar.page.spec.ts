import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeCalendarPage } from './home-calendar.page';

describe('HomeCalendarPage', () => {
  let component: HomeCalendarPage;
  let fixture: ComponentFixture<HomeCalendarPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeCalendarPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeCalendarPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

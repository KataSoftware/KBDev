import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppListBasePage } from './app-list-base.page';

describe('AppListBasePage', () => {
  let component: AppListBasePage;
  let fixture: ComponentFixture<AppListBasePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppListBasePage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppListBasePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

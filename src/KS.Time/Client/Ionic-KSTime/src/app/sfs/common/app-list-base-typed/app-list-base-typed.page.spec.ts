import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppListBaseTypedPage } from './app-list-base-typed.page';

describe('AppListBaseTypedPage', () => {
  let component: AppListBaseTypedPage<any>;
  let fixture: ComponentFixture<AppListBaseTypedPage<any>>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppListBaseTypedPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppListBaseTypedPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppFormBasePage } from './app-form-base.page';

describe('AppFormBasePage', () => {
  let component: AppFormBasePage;
  let fixture: ComponentFixture<AppFormBasePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppFormBasePage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppFormBasePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterWorkTimePage } from './register-work-time.page';

describe('RegisterWorkTimePage', () => {
  let component: RegisterWorkTimePage;
  let fixture: ComponentFixture<RegisterWorkTimePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegisterWorkTimePage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterWorkTimePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

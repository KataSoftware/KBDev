import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormlyWrapperAddonsPage } from './formly-wrapper-addons.page';

describe('FormlyWrapperAddonsPage', () => {
  let component: FormlyWrapperAddonsPage;
  let fixture: ComponentFixture<FormlyWrapperAddonsPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormlyWrapperAddonsPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormlyWrapperAddonsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

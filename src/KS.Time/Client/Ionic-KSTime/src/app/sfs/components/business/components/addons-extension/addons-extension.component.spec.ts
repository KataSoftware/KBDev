import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddonsExtensionPage } from './addons-extension.page';

describe('AddonsExtensionPage', () => {
  let component: AddonsExtensionPage;
  let fixture: ComponentFixture<AddonsExtensionPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddonsExtensionPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddonsExtensionPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

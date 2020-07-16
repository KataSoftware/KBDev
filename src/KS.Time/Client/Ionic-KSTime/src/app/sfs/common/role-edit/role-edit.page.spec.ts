import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoleEditPage } from './role-edit.page';

describe('RoleEditPage', () => {
  let component: RoleEditPage;
  let fixture: ComponentFixture<RoleEditPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoleEditPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoleEditPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

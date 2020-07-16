import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserRoleEditPage } from './user-role-edit.page';

describe('UserRoleEditPage', () => {
  let component: UserRoleEditPage;
  let fixture: ComponentFixture<UserRoleEditPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserRoleEditPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserRoleEditPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

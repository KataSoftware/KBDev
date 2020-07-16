import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserRolesPage } from './user-roles.page';

describe('UserRolesPage', () => {
  let component: UserRolesPage;
  let fixture: ComponentFixture<UserRolesPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserRolesPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserRolesPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserMenuPage } from './user-menu.page';

describe('UserMenuPage', () => {
  let component: UserMenuPage;
  let fixture: ComponentFixture<UserMenuPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserMenuPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserMenuPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

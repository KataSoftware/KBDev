import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SFSFieldPage } from './sfsfield.page';

describe('SfsinputPage', () => {
  let component: SFSFieldPage;
  let fixture: ComponentFixture<SFSFieldPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SFSFieldPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SFSFieldPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

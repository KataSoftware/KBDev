import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EventLogsPage } from './event-logs-page.page';

describe('EventLogPagePage', () => {
  let component: EventLogsPage;
  let fixture: ComponentFixture<EventLogsPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EventLogsPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EventLogsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { Component, OnInit, LOCALE_ID, ViewChild, Inject, Injector } from '@angular/core';
import { CalendarComponent } from 'ionic2-calendar/calendar';
import { formatDate } from '@angular/common';
import { KstWorkTimeModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from '../../common/app-list-base-typed/app-list-base-typed.page';
import { StorageService, UserService } from 'sfscommon';

import { sfsService } from 'src/app/services/common/sfs.service';


@Component({
 selector: 'app-home-calendar',
 templateUrl: './home-calendar.page.html',
 styleUrls: ['./home-calendar.page.scss'],
})
export class HomeCalendarPage extends AppListBaseTypedPage<KstWorkTimeModel> implements OnInit {
  eventSource;
    viewTitle;

    isToday:boolean;
    calendar = {
        mode: 'month',
        currentDate: new Date(),
        dateFormatter: {
            formatMonthViewDay: function(date:Date) {
                return date.getDate().toString();
            },
            formatMonthViewDayHeader: function(date:Date) {
                return 'MonMH';
            },
            formatMonthViewTitle: function(date:Date) {
                return 'testMT';
            },
            formatWeekViewDayHeader: function(date:Date) {
                return 'MonWH';
            },
            formatWeekViewTitle: function(date:Date) {
                return 'testWT';
            },
            formatWeekViewHourColumn: function(date:Date) {
                return 'testWH';
            },
            formatDayViewHourColumn: function(date:Date) {
                return 'testDH';
            },
            formatDayViewTitle: function(date:Date) {
                return 'testDT';
            }
        }
    };

    constructor(public injector: Injector,

      public storage: StorageService,
      public userService: UserService,
    public sfsService: sfsService) {
      super(injector);
    }
  ngOnInit(): void {
    //throw new Error("Method not implemented.");
  }

    loadEvents() {
       // this.eventSource = this.createRandomEvents();
    }

    onViewTitleChanged(title) {
        this.viewTitle = title;
    }

    onEventSelected(event) {
        console.log('Event selected:' + event.startTime + '-' + event.endTime + ',' + event.title);
    }

    changeMode(mode) {
        this.calendar.mode = mode;
    }

    today() {
        this.calendar.currentDate = new Date();
    }

    onTimeSelected(ev) {
        console.log('Selected time: ' + ev.selectedTime + ', hasEvents: ' +
            (ev.events !== undefined && ev.events.length !== 0) + ', disabled: ' + ev.disabled);
      this.navCtrl.navigateForward("KstWorkTime/form");
    }

    onCurrentDateChanged(event:Date) {
        var today = new Date();
        today.setHours(0, 0, 0, 0);
        event.setHours(0, 0, 0, 0);
        this.isToday = today.getTime() === event.getTime();
    }

    onRangeChanged(ev) {
      console.log('range changed: startTime: ' + ev.startTime + ', endTime: ' + ev.endTime);
  }

  markDisabled = (date:Date) => {
      var current = new Date();
      current.setHours(0, 0, 0);
      return date < current;
  };

}
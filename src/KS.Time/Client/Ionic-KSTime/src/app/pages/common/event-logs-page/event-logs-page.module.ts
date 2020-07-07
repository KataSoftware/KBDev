import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { EventLogsPage } from './event-logs-page.page';
import { SFSCommonModule } from 'sfscommon';
import { timeagoModule } from 'src/app/pipes/common/timeago.module';
import { MatCheckboxModule } from '@angular/material/checkbox';

const routes: Routes = [
  {
    path: '',
    component: EventLogsPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    SFSCommonModule,
    MatCheckboxModule,
    IonicModule,
    timeagoModule,
    RouterModule.forChild(routes)
  ],
  declarations: [EventLogsPage]
})
export class EventLogsPageModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { EventLogPage } from './event-log.page';
import { MatSelectModule } from '@angular/material/select';

const routes: Routes = [
  {
    path: '',
    component: EventLogPage
  }
];

@NgModule({
  imports: [
    CommonModule,
 
    IonicModule,
    FormsModule,
    ReactiveFormsModule,
    MatSelectModule,
    RouterModule.forChild(routes)
  ],
  declarations: [EventLogPage]
})
export class EventLogPageModule {}

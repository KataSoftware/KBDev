import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { SystemPage } from './system.page';
import { MatGridListModule } from '@angular/material/grid-list';



const routes: Routes = [
  {
    path: '',
    component: SystemPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MatGridListModule,
    RouterModule.forChild(routes)
  ],
  declarations: [SystemPage]
})
export class SystemPageModule {}

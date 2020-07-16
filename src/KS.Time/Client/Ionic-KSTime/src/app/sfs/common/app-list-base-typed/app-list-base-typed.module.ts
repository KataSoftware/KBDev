import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { AppListBaseTypedPage } from './app-list-base-typed.page';

const routes: Routes = [
  {
    path: '',
    component: AppListBaseTypedPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [AppListBaseTypedPage]
})
export class AppListBaseTypedPageModule {}

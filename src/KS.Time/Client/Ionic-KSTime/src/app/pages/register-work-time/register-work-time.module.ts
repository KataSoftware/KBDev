import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { RegisterWorkTimePage } from './register-work-time.page';

const routes: Routes = [
  {
    path: '',
    component: RegisterWorkTimePage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [RegisterWorkTimePage]
})
export class RegisterWorkTimePageModule {}

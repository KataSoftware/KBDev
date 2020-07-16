import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { ApplicationTutorialPage } from './application-tutorial.page';

const routes: Routes = [
  {
    path: '',
    component: ApplicationTutorialPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [ApplicationTutorialPage]
})
export class ApplicationTutorialPageModule {}

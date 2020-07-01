import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { UsersPage } from './users.page';
import { SFSCommonModule } from 'sfscommon';
import { MatCheckboxModule } from '@angular/material';

const routes: Routes = [
  {
    path: '',
    component: UsersPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SFSCommonModule,
    MatCheckboxModule,
    RouterModule.forChild(routes)
  ],
  declarations: [UsersPage]
})
export class UsersPageModule {}

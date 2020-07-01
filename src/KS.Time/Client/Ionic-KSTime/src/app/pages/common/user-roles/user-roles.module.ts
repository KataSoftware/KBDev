import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { UserRolesPage } from './user-roles.page';
import { SFSCommonModule } from 'sfscommon';
import { MatCheckboxModule } from '@angular/material/checkbox';

const routes: Routes = [
  {
    path: '',
    component: UserRolesPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    SFSCommonModule,
    MatCheckboxModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [UserRolesPage]
})
export class UserRolesPageModule {}

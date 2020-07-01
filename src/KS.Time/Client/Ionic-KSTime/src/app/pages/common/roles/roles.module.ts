import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { RolesPage } from './roles.page';
import { SFSCommonModule } from 'sfscommon';
import { MatCheckboxModule } from '@angular/material';

const routes: Routes = [
  {
    path: '',
    component: RolesPage
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
  declarations: [RolesPage]
})
export class RolesPageModule {}

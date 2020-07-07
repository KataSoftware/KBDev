import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { RoleEditPage } from './role-edit.page';
import { SFSCommonModule } from 'sfscommon';
import { MatSelectModule } from '@angular/material/select';


const routes: Routes = [
  {
    path: '',
    component: RoleEditPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MatSelectModule,
    ReactiveFormsModule,
    RouterModule.forChild(routes)
  ],
  declarations: [RoleEditPage]
})
export class RoleEditPageModule {}

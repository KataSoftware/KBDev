﻿import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { KstFileFormPage } from './KstFile-form.page';
import { SFSCommonModule } from 'sfscommon';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyConfig } from 'src/app/shared/common/formly';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { SharedModule } from 'src/app/shared/shared.module';

const routes: Routes = [
  {
    path: '',
    component: KstFileFormPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SFSCommonModule,
	SharedModule,
    ReactiveFormsModule,
    FormlyModule.forRoot(FormlyConfig),
    FormlyMaterialModule,
    
    
    RouterModule.forChild(routes)
  ],
  declarations: [KstFileFormPage]
})
export class KstFileFormPageModule {}


import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { GenericFormPageRoutingModule } from './generic-form-routing.module';

//import { GenericFormPage } from './generic-form.page';
import { SFSCommonModule } from 'sfscommon';
import { SharedModule } from '../../shared/shared.module';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { FormlyConfig } from '../../shared/common/formly';
import { GenericFormPage } from './generic-form.page';



@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    GenericFormPageRoutingModule,
    SFSCommonModule,
	  SharedModule,
    ReactiveFormsModule,
    FormlyModule.forRoot(FormlyConfig),
    FormlyMaterialModule,
  ],
  declarations: [ GenericFormPage ]
})
export class GenericFormPageModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

//import { GenericFormPage } from './generic-form.page';
import { SFSCommonModule } from 'sfscommon';
import { SharedModule } from '../../shared/shared.module';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { FormlyConfig } from '../../shared/common/formly';
import { GenericModalComponent } from './generic-modal.component';



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
  ],
  declarations: [ GenericModalComponent ]
})
export class GenericModalComponentModule {}

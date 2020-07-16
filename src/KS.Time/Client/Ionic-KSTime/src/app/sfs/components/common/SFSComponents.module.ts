import { NgModule } from '@angular/core';
import { IonicModule } from '@ionic/angular';
import { SFSFieldComponent } from './sfsinput/sfsfield.component';
import { CommonModule } from '@angular/common';
import { SFSCommonModule } from 'sfscommon';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';


@NgModule({
  declarations: [
    SFSFieldComponent
  ],
  exports: [
    SFSFieldComponent
  ],
  imports: [
    IonicModule,
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    IonicModule,
    SFSCommonModule,
    FormsModule,
    ReactiveFormsModule,
  ]
})
export class SFSComponentsModule {}
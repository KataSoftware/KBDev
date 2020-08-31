import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { MatMenuModule } from '@angular/material/menu';
import { IonicModule } from '@ionic/angular';

import { GenericListPage } from './generic-list.page';
import { SFSCommonModule } from 'sfscommon';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatIconModule } from '@angular/material/icon';
import { TimeAgoPipe } from '../../pipes/common/timeago';
import { timeagoModule } from '../../pipes/common/timeago.module';
import { SharedModule } from '../../shared/shared.module';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyConfig } from '../../shared/common/formly';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { MatExpansionModule } from '@angular/material/expansion';
import { GenericModalComponent } from '../generic-modal/generic-modal.component';


const routes: Routes = [
  {
    path: '',
    component: GenericListPage
  }
];

@NgModule({
  entryComponents: [  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    FormlyModule.forRoot(FormlyConfig),
    FormlyMaterialModule,
    IonicModule,
    MatIconModule,
    SFSCommonModule,
    MatCheckboxModule,
    MatExpansionModule,
    MatMenuModule,
    timeagoModule,

    RouterModule.forChild(routes)
  ],

  declarations: [GenericListPage]
})
export class GenericListPageModule { }



import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { MatMenuModule } from '@angular/material/menu';
import { IonicModule } from '@ionic/angular';

import { KstProjectUserListPage } from './KstProjectUser-list.page';
import { SFSCommonModule } from 'sfscommon';
import { MatCheckboxModule } from '@angular/material/checkbox';
import {MatIconModule} from '@angular/material/icon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { timeagoModule } from 'src/app/pipes/common/timeago.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyConfig } from 'src/app/shared/common/formly';
import { FormlyMaterialModule } from '@ngx-formly/material';

const routes: Routes = [
  {
    path: '',
    component: KstProjectUserListPage
  }
];

@NgModule({
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
	MatMenuModule,
    timeagoModule,
    RouterModule.forChild(routes)
  ],
  declarations: [KstProjectUserListPage]
})
export class KstProjectUserListPageModule {}



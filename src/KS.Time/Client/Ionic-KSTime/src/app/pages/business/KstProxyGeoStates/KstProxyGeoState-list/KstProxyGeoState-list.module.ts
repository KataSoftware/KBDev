import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { MatMenuModule } from '@angular/material/menu';
import { IonicModule } from '@ionic/angular';

import { KstProxyGeoStateListPage } from './KstProxyGeoState-list.page';
import { SFSCommonModule } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { timeagoModule } from 'src/app/pipes/common/timeago.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyConfig } from 'src/app/shared/common/formly';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { MatIconModule } from '@angular/material/icon';
import { MatCheckboxModule } from '@angular/material/checkbox';

const routes: Routes = [
  {
    path: '',
    component: KstProxyGeoStateListPage
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
  declarations: [KstProxyGeoStateListPage]
})
export class KstProxyGeoStateListPageModule {}



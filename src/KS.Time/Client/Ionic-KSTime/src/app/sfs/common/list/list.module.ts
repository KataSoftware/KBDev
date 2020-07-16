import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';

import { MyListPage } from './list.page';
import { DynamicFormComponent, SFSComponentModule } from 'sfscommon';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild([
      {
        path: '',
        component: MyListPage
      }
    ]),
    SFSComponentModule.forChild(DynamicFormComponent),
  ],
  declarations: [MyListPage]
})
export class ListPageModule { }

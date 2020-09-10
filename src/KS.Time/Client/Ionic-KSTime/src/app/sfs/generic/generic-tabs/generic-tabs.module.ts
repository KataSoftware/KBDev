import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { GenericTabsPageRoutingModule } from './generic-tabs-routing.module';

import { GenericTabsPage } from './generic-tabs.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    GenericTabsPageRoutingModule
  ],
  declarations: [GenericTabsPage]
})
export class GenericTabsPageModule {}

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GenericTabsPage } from './generic-tabs.page';

const routes: Routes = [
  {
    path: '',
    component: GenericTabsPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class GenericTabsPageRoutingModule {}

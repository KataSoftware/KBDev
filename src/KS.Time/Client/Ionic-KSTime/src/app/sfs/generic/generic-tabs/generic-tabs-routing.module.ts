import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GenericTabsPage } from './generic-tabs.page';

const routes: Routes = [
  {
    path: '',
    component: GenericTabsPage,
    children: [
      {
        path: 'principal',
        loadChildren: () =>
        //{ 
         // console.log();
             import('../generic-form/generic-form.module').then(m => m.GenericFormPageModule) 
        //}
      },
      {
        path: 'relations',
        loadChildren: () =>
        //{ 
         // console.log();
             import('../generic-list/generic-list.module').then(m => m.GenericListPageModule) 
        //}
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class GenericTabsPageRoutingModule {}

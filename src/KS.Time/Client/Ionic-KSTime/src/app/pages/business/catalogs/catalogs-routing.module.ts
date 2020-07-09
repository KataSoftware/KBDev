import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuardService } from 'sfscommon';


const routes: Routes = [

  { path: 'KstEmailTemplate/list',  canActivate: [AuthGuardService], loadChildren: './KstEmailTemplates/KstEmailTemplate-list/KstEmailTemplate-list.module#KstEmailTemplateListPageModule' },
  { path: 'KstEmailTemplate/form/:Id',  canActivate: [AuthGuardService], loadChildren: './KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module#KstEmailTemplateFormPageModule' },
  { path: 'KstEmailTemplate/form',  canActivate: [AuthGuardService], loadChildren: './KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module#KstEmailTemplateFormPageModule' },




];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CatalogsRoutingModule { }

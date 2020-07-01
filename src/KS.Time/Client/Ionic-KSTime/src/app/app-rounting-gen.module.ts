// Angular Imports
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// SFSCommon Imports
import { EntityPageModule, EntityListPage, EntityListPageModule, SelectCompanyPageModule } from 'sfscommon';
import { AuthGuardService } from './services/common/AuthGuard.service';


export class AppRoutingGenModule {
public static routesGen: Routes = [

  { path: 'KstEmailTemplate/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstEmailTemplates/KstEmailTemplate-list/KstEmailTemplate-list.module#KstEmailTemplateListPageModule' },
  { path: 'KstEmailTemplate/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module#KstEmailTemplateFormPageModule' },
  { path: 'KstEmailTemplate/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module#KstEmailTemplateFormPageModule' },


  { path: 'KstProxyGeoCity/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCities/KstProxyGeoCity-list/KstProxyGeoCity-list.module#KstProxyGeoCityListPageModule' },
  { path: 'KstProxyGeoCity/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCities/KstProxyGeoCity-form/KstProxyGeoCity-form.module#KstProxyGeoCityFormPageModule' },
  { path: 'KstProxyGeoCity/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCities/KstProxyGeoCity-form/KstProxyGeoCity-form.module#KstProxyGeoCityFormPageModule' },


  { path: 'KstProxyGeoCountry/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCountries/KstProxyGeoCountry-list/KstProxyGeoCountry-list.module#KstProxyGeoCountryListPageModule' },
  { path: 'KstProxyGeoCountry/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCountries/KstProxyGeoCountry-form/KstProxyGeoCountry-form.module#KstProxyGeoCountryFormPageModule' },
  { path: 'KstProxyGeoCountry/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoCountries/KstProxyGeoCountry-form/KstProxyGeoCountry-form.module#KstProxyGeoCountryFormPageModule' },


  { path: 'KstProxyGeoState/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoStates/KstProxyGeoState-list/KstProxyGeoState-list.module#KstProxyGeoStateListPageModule' },
  { path: 'KstProxyGeoState/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoStates/KstProxyGeoState-form/KstProxyGeoState-form.module#KstProxyGeoStateFormPageModule' },
  { path: 'KstProxyGeoState/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyGeoStates/KstProxyGeoState-form/KstProxyGeoState-form.module#KstProxyGeoStateFormPageModule' },


  { path: 'KstActivity/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstActivities/KstActivity-list/KstActivity-list.module#KstActivityListPageModule' },
  { path: 'KstActivity/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstActivities/KstActivity-form/KstActivity-form.module#KstActivityFormPageModule' },
  { path: 'KstActivity/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstActivities/KstActivity-form/KstActivity-form.module#KstActivityFormPageModule' },


  { path: 'KstProject/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjects/KstProject-list/KstProject-list.module#KstProjectListPageModule' },
  { path: 'KstProject/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjects/KstProject-form/KstProject-form.module#KstProjectFormPageModule' },
  { path: 'KstProject/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjects/KstProject-form/KstProject-form.module#KstProjectFormPageModule' },


  { path: 'KstProjectUser/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectUsers/KstProjectUser-list/KstProjectUser-list.module#KstProjectUserListPageModule' },
  { path: 'KstProjectUser/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectUsers/KstProjectUser-form/KstProjectUser-form.module#KstProjectUserFormPageModule' },
  { path: 'KstProjectUser/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectUsers/KstProjectUser-form/KstProjectUser-form.module#KstProjectUserFormPageModule' },


  { path: 'KstWorkTime/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimes/KstWorkTime-list/KstWorkTime-list.module#KstWorkTimeListPageModule' },
  { path: 'KstWorkTime/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimes/KstWorkTime-form/KstWorkTime-form.module#KstWorkTimeFormPageModule' },
  { path: 'KstWorkTime/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimes/KstWorkTime-form/KstWorkTime-form.module#KstWorkTimeFormPageModule' },


  { path: 'KstFile/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstFiles/KstFile-list/KstFile-list.module#KstFileListPageModule' },
  { path: 'KstFile/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstFiles/KstFile-form/KstFile-form.module#KstFileFormPageModule' },
  { path: 'KstFile/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstFiles/KstFile-form/KstFile-form.module#KstFileFormPageModule' },


  { path: 'KstProjectFile/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectFiles/KstProjectFile-list/KstProjectFile-list.module#KstProjectFileListPageModule' },
  { path: 'KstProjectFile/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectFiles/KstProjectFile-form/KstProjectFile-form.module#KstProjectFileFormPageModule' },
  { path: 'KstProjectFile/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProjectFiles/KstProjectFile-form/KstProjectFile-form.module#KstProjectFileFormPageModule' },


  { path: 'KstUserFile/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstUserFiles/KstUserFile-list/KstUserFile-list.module#KstUserFileListPageModule' },
  { path: 'KstUserFile/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstUserFiles/KstUserFile-form/KstUserFile-form.module#KstUserFileFormPageModule' },
  { path: 'KstUserFile/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstUserFiles/KstUserFile-form/KstUserFile-form.module#KstUserFileFormPageModule' },


  { path: 'KstWorkTimeFile/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimeFiles/KstWorkTimeFile-list/KstWorkTimeFile-list.module#KstWorkTimeFileListPageModule' },
  { path: 'KstWorkTimeFile/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimeFiles/KstWorkTimeFile-form/KstWorkTimeFile-form.module#KstWorkTimeFileFormPageModule' },
  { path: 'KstWorkTimeFile/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstWorkTimeFiles/KstWorkTimeFile-form/KstWorkTimeFile-form.module#KstWorkTimeFileFormPageModule' },


  { path: 'KstProxyRole/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyRoles/KstProxyRole-list/KstProxyRole-list.module#KstProxyRoleListPageModule' },
  { path: 'KstProxyRole/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyRoles/KstProxyRole-form/KstProxyRole-form.module#KstProxyRoleFormPageModule' },
  { path: 'KstProxyRole/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyRoles/KstProxyRole-form/KstProxyRole-form.module#KstProxyRoleFormPageModule' },


  { path: 'KstProxyUser/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyUsers/KstProxyUser-list/KstProxyUser-list.module#KstProxyUserListPageModule' },
  { path: 'KstProxyUser/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyUsers/KstProxyUser-form/KstProxyUser-form.module#KstProxyUserFormPageModule' },
  { path: 'KstProxyUser/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/KstProxyUsers/KstProxyUser-form/KstProxyUser-form.module#KstProxyUserFormPageModule' },


  { path: 'unProxyBusinessObject/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyBusinessObjects/unProxyBusinessObject-list/unProxyBusinessObject-list.module#unProxyBusinessObjectListPageModule' },
  { path: 'unProxyBusinessObject/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyBusinessObjects/unProxyBusinessObject-form/unProxyBusinessObject-form.module#unProxyBusinessObjectFormPageModule' },
  { path: 'unProxyBusinessObject/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyBusinessObjects/unProxyBusinessObject-form/unProxyBusinessObject-form.module#unProxyBusinessObjectFormPageModule' },


  { path: 'unProxyEvent/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyEvents/unProxyEvent-list/unProxyEvent-list.module#unProxyEventListPageModule' },
  { path: 'unProxyEvent/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyEvents/unProxyEvent-form/unProxyEvent-form.module#unProxyEventFormPageModule' },
  { path: 'unProxyEvent/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxyEvents/unProxyEvent-form/unProxyEvent-form.module#unProxyEventFormPageModule' },


  { path: 'unProxySetting/list',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxySettings/unProxySetting-list/unProxySetting-list.module#unProxySettingListPageModule' },
  { path: 'unProxySetting/form/:Id',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxySettings/unProxySetting-form/unProxySetting-form.module#unProxySettingFormPageModule' },
  { path: 'unProxySetting/form',  canActivate: [AuthGuardService], loadChildren: './pages/business/unProxySettings/unProxySetting-form/unProxySetting-form.module#unProxySettingFormPageModule' },


];


 }



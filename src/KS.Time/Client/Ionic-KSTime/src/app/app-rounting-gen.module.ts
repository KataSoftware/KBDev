// Angular Imports
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// SFSCommon Imports
import { EntityPageModule, EntityListPage, EntityListPageModule, SelectCompanyPageModule } from 'sfscommon';
import { AuthGuardService } from './services/common/AuthGuard.service';


export class AppRoutingGenModule {
public static routesGen: Routes = [



  { path: 'KstEmailTemplate/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstEmailTemplates/KstEmailTemplate-list/KstEmailTemplate-list.module').then(m => m.KstEmailTemplateListPageModule)  },
  { path: 'KstEmailTemplate/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module').then(m => m.KstEmailTemplateFormPageModule) },
  { path: 'KstEmailTemplate/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstEmailTemplates/KstEmailTemplate-form/KstEmailTemplate-form.module').then(m => m.KstEmailTemplateFormPageModule) },



  { path: 'KstProxyGeoCity/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCities/KstProxyGeoCity-list/KstProxyGeoCity-list.module').then(m => m.KstProxyGeoCityListPageModule)  },
  { path: 'KstProxyGeoCity/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCities/KstProxyGeoCity-form/KstProxyGeoCity-form.module').then(m => m.KstProxyGeoCityFormPageModule) },
  { path: 'KstProxyGeoCity/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCities/KstProxyGeoCity-form/KstProxyGeoCity-form.module').then(m => m.KstProxyGeoCityFormPageModule) },



  { path: 'KstProxyGeoCountry/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCountries/KstProxyGeoCountry-list/KstProxyGeoCountry-list.module').then(m => m.KstProxyGeoCountryListPageModule)  },
  { path: 'KstProxyGeoCountry/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCountries/KstProxyGeoCountry-form/KstProxyGeoCountry-form.module').then(m => m.KstProxyGeoCountryFormPageModule) },
  { path: 'KstProxyGeoCountry/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoCountries/KstProxyGeoCountry-form/KstProxyGeoCountry-form.module').then(m => m.KstProxyGeoCountryFormPageModule) },



  { path: 'KstProxyGeoState/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoStates/KstProxyGeoState-list/KstProxyGeoState-list.module').then(m => m.KstProxyGeoStateListPageModule)  },
  { path: 'KstProxyGeoState/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoStates/KstProxyGeoState-form/KstProxyGeoState-form.module').then(m => m.KstProxyGeoStateFormPageModule) },
  { path: 'KstProxyGeoState/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyGeoStates/KstProxyGeoState-form/KstProxyGeoState-form.module').then(m => m.KstProxyGeoStateFormPageModule) },



  { path: 'KstActivity/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstActivities/KstActivity-list/KstActivity-list.module').then(m => m.KstActivityListPageModule)  },
  { path: 'KstActivity/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstActivities/KstActivity-form/KstActivity-form.module').then(m => m.KstActivityFormPageModule) },
  { path: 'KstActivity/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstActivities/KstActivity-form/KstActivity-form.module').then(m => m.KstActivityFormPageModule) },



  { path: 'KstProject/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjects/KstProject-list/KstProject-list.module').then(m => m.KstProjectListPageModule)  },
  { path: 'KstProject/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjects/KstProject-form/KstProject-form.module').then(m => m.KstProjectFormPageModule) },
  { path: 'KstProject/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjects/KstProject-form/KstProject-form.module').then(m => m.KstProjectFormPageModule) },



  { path: 'KstProjectUser/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectUsers/KstProjectUser-list/KstProjectUser-list.module').then(m => m.KstProjectUserListPageModule)  },
  { path: 'KstProjectUser/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectUsers/KstProjectUser-form/KstProjectUser-form.module').then(m => m.KstProjectUserFormPageModule) },
  { path: 'KstProjectUser/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectUsers/KstProjectUser-form/KstProjectUser-form.module').then(m => m.KstProjectUserFormPageModule) },



  { path: 'KstWorkTime/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimes/KstWorkTime-list/KstWorkTime-list.module').then(m => m.KstWorkTimeListPageModule)  },
  { path: 'KstWorkTime/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimes/KstWorkTime-form/KstWorkTime-form.module').then(m => m.KstWorkTimeFormPageModule) },
  { path: 'KstWorkTime/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimes/KstWorkTime-form/KstWorkTime-form.module').then(m => m.KstWorkTimeFormPageModule) },



  { path: 'KstFile/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstFiles/KstFile-list/KstFile-list.module').then(m => m.KstFileListPageModule)  },
  { path: 'KstFile/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstFiles/KstFile-form/KstFile-form.module').then(m => m.KstFileFormPageModule) },
  { path: 'KstFile/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstFiles/KstFile-form/KstFile-form.module').then(m => m.KstFileFormPageModule) },



  { path: 'KstProjectFile/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectFiles/KstProjectFile-list/KstProjectFile-list.module').then(m => m.KstProjectFileListPageModule)  },
  { path: 'KstProjectFile/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectFiles/KstProjectFile-form/KstProjectFile-form.module').then(m => m.KstProjectFileFormPageModule) },
  { path: 'KstProjectFile/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProjectFiles/KstProjectFile-form/KstProjectFile-form.module').then(m => m.KstProjectFileFormPageModule) },



  { path: 'KstUserFile/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstUserFiles/KstUserFile-list/KstUserFile-list.module').then(m => m.KstUserFileListPageModule)  },
  { path: 'KstUserFile/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstUserFiles/KstUserFile-form/KstUserFile-form.module').then(m => m.KstUserFileFormPageModule) },
  { path: 'KstUserFile/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstUserFiles/KstUserFile-form/KstUserFile-form.module').then(m => m.KstUserFileFormPageModule) },



  { path: 'KstWorkTimeFile/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimeFiles/KstWorkTimeFile-list/KstWorkTimeFile-list.module').then(m => m.KstWorkTimeFileListPageModule)  },
  { path: 'KstWorkTimeFile/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimeFiles/KstWorkTimeFile-form/KstWorkTimeFile-form.module').then(m => m.KstWorkTimeFileFormPageModule) },
  { path: 'KstWorkTimeFile/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstWorkTimeFiles/KstWorkTimeFile-form/KstWorkTimeFile-form.module').then(m => m.KstWorkTimeFileFormPageModule) },



  { path: 'KstProxyRole/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyRoles/KstProxyRole-list/KstProxyRole-list.module').then(m => m.KstProxyRoleListPageModule)  },
  { path: 'KstProxyRole/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyRoles/KstProxyRole-form/KstProxyRole-form.module').then(m => m.KstProxyRoleFormPageModule) },
  { path: 'KstProxyRole/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyRoles/KstProxyRole-form/KstProxyRole-form.module').then(m => m.KstProxyRoleFormPageModule) },



  { path: 'KstProxyUser/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyUsers/KstProxyUser-list/KstProxyUser-list.module').then(m => m.KstProxyUserListPageModule)  },
  { path: 'KstProxyUser/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyUsers/KstProxyUser-form/KstProxyUser-form.module').then(m => m.KstProxyUserFormPageModule) },
  { path: 'KstProxyUser/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/KstProxyUsers/KstProxyUser-form/KstProxyUser-form.module').then(m => m.KstProxyUserFormPageModule) },



  { path: 'unProxyBusinessObject/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyBusinessObjects/unProxyBusinessObject-list/unProxyBusinessObject-list.module').then(m => m.unProxyBusinessObjectListPageModule)  },
  { path: 'unProxyBusinessObject/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyBusinessObjects/unProxyBusinessObject-form/unProxyBusinessObject-form.module').then(m => m.unProxyBusinessObjectFormPageModule) },
  { path: 'unProxyBusinessObject/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyBusinessObjects/unProxyBusinessObject-form/unProxyBusinessObject-form.module').then(m => m.unProxyBusinessObjectFormPageModule) },



  { path: 'unProxyEvent/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyEvents/unProxyEvent-list/unProxyEvent-list.module').then(m => m.unProxyEventListPageModule)  },
  { path: 'unProxyEvent/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyEvents/unProxyEvent-form/unProxyEvent-form.module').then(m => m.unProxyEventFormPageModule) },
  { path: 'unProxyEvent/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxyEvents/unProxyEvent-form/unProxyEvent-form.module').then(m => m.unProxyEventFormPageModule) },



  { path: 'unProxySetting/list',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxySettings/unProxySetting-list/unProxySetting-list.module').then(m => m.unProxySettingListPageModule)  },
  { path: 'unProxySetting/form/:Id',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxySettings/unProxySetting-form/unProxySetting-form.module').then(m => m.unProxySettingFormPageModule) },
  { path: 'unProxySetting/form',  canActivate: [AuthGuardService], 
    loadChildren: () => import('./pages/business/unProxySettings/unProxySetting-form/unProxySetting-form.module').then(m => m.unProxySettingFormPageModule) },



];


 }



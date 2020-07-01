import { AppRoutingGenModule } from './app-rounting-gen.module';
// Angular Imports
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// SFSCommon Imports
import { EntityPageModule, EntityListPage, EntityListPageModule, SelectCompanyPageModule } from 'sfscommon';
import { AuthGuardService } from './services/common/AuthGuard.service';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
    canActivate: [AuthGuardService]
  },
  {
    path: 'login',
    // loadChildren: () => LoginPageModule,
    loadChildren: './pages/common/login/login.module#LoginPageModule',
  },
  {
    path: 'recovery-password',
    // loadChildren: () => LoginPageModule,
    loadChildren: './pages/common/login/login.module#LoginPageModule',
  },
  {
    path: 'set-password/email/:email/code/:code',
    // loadChildren: () => LoginPageModule,
    loadChildren: './pages/common/login/login.module#LoginPageModule',
  },
  {
    path: 'activate-account/email/:email/code/:code',
    // loadChildren: () => LoginPageModule,
    loadChildren: './pages/common/login/login.module#LoginPageModule',
  },
  {
    path: 'activate-account-go/email/:email/code/:code',
    // loadChildren: () => LoginPageModule,
    loadChildren: './pages/common/login/login.module#LoginPageModule',
  },
  {
    path: 'home',
    canActivate: [AuthGuardService],
    loadChildren: './pages/common/home/home.module#HomePageModule',
   
  }
  ,
  {
    path: 'list',
    loadChildren: './pages/common/list/list.module#ListPageModule',
    canActivate: [AuthGuardService]
  },
  {
    path: 'application-tutorial',
    loadChildren: './pages/common/application-tutorial/application-tutorial.module#ApplicationTutorialPageModule',
    canActivate: [AuthGuardService]
  },
  
 
  { path: 'selectcompany', loadChildren: () => SelectCompanyPageModule },
  
  { path: 'system', loadChildren: './pages/common/system/system.module#SystemPageModule' },
  { path: 'system/users', loadChildren: './pages/common/users/users.module#UsersPageModule' },
  { path: 'system/users/create', loadChildren: './pages/common/user-create/user-create.module#UserCreatePageModule' },
  { path: 'system/users/detail/:guidUser', loadChildren: './pages/common/user-create/user-create.module#UserCreatePageModule' },
  { path: 'system/roles', loadChildren: './pages/common/roles/roles.module#RolesPageModule' },
  { path: 'system/roles/create', loadChildren: './pages/common/role-edit/role-edit.module#RoleEditPageModule' },
  { path: 'system/roles/detail/:guidRole', loadChildren: './pages/common/role-edit/role-edit.module#RoleEditPageModule' },
  { path: 'system/users-roles', loadChildren: './pages/common/user-roles/user-roles.module#UserRolesPageModule' },
  { path: 'system/users-roles/user/:guidUser', loadChildren: './pages/common/user-roles/user-roles.module#UserRolesPageModule' },
  { path: 'system/users-roles/detail/:guidUserCompany', loadChildren: './pages/common/user-role-edit/user-role-edit.module#UserRoleEditPageModule' },
  { path: 'system/users-roles/create', loadChildren: './pages/common/user-role-edit/user-role-edit.module#UserRoleEditPageModule' },
  { path: 'system/users-roles/user/:guidUser/create', loadChildren: './pages/common/user-role-edit/user-role-edit.module#UserRoleEditPageModule' },
   { path: 'system/events', loadChildren: './pages/common/event-logs-page/event-logs-page.module#EventLogsPageModule' },
  { path: 'system/events/detail/:Id', loadChildren: './pages/common/event-log/event-log.module#EventLogPageModule' },
  { path: 'system/settings', loadChildren: './pages/common/settings/settings.module#SettingsPageModule' },
  
  { path: 'home', canActivate: [AuthGuardService], loadChildren: './pages/common/home/home.module#HomePageModule' },  { path: 'home-calendar', loadChildren: './pages/business/home-calendar/home-calendar.module#HomeCalendarPageModule' },
  { path: 'register-work-time', loadChildren: './pages/business/register-work-time/register-work-time.module#RegisterWorkTimePageModule' },

    

];

@NgModule({
  imports: [RouterModule.forRoot([ ...routes, ...AppRoutingGenModule.routesGen], { useHash: true, paramsInheritanceStrategy: 'always' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }

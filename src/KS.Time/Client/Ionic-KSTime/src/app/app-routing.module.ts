import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { AuthGuardService } from './sfs/services/AuthGuard.service';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'FolderIn/Inbox',
    pathMatch: 'full'
  },
  {
    path: 'FolderIn/:id',
    loadChildren: () => import('./folder/Folder-In.module').then( m => m.FolderPageModule)
  },
  {
    path: 'login',
    loadChildren: () => import('./sfs/common/login/login.module').then( m => m.LoginPageModule)
  },
  
  

  {
    path: 'catalog/:catalog',
    canActivate: [AuthGuardService],
    loadChildren: () => import('./sfs/generic/generic-list/generic-list.module').then( m => m.GenericListPageModule)
  },
  {
    path: 'catalog/:catalog/form',
    canActivate: [AuthGuardService],
    loadChildren: () => import('./sfs/generic/generic-form/generic-form.module').then( m => m.GenericFormPageModule)
  },
  {
    path: 'catalog/:catalog/form/:id',
    canActivate: [AuthGuardService],
    loadChildren: () => import('./sfs//generic/generic-form/generic-form.module').then( m => m.GenericFormPageModule)
  },

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}

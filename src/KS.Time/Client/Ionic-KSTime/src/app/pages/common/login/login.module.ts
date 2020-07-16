import { FormlyBootstrapModule } from '@ngx-formly/bootstrap';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { SFSCommonModule } from 'sfscommon';
import { FormlyModule } from '@ngx-formly/core';

import { FormlyConfig } from 'src/app/shared/common/formly';
import { SharedModule } from 'src/app/shared/shared.module';

//import { RecaptchaModule } from 'ng-recaptcha';
import { MainMenuButtonModule } from 'src/app/components/business/main-menu-button/main-menu-button.module';
import { LocalLoginPage } from './login.page';
//import { PersistenceModule } from 'angular-persistence';


const routes: Routes = [
  {
    path: '',
    component: LocalLoginPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SFSCommonModule,
    SharedModule,
    ReactiveFormsModule,
    FormlyModule.forRoot(FormlyConfig),
    FormlyMaterialModule,
   // RecaptchaModule,
   // PersistenceModule,
   MainMenuButtonModule,
    RouterModule.forChild(routes)
  ],
  declarations: [LocalLoginPage]
})
export class LoginPageModule {}

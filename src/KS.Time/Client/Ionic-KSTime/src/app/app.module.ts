import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
//import {BrowserModule, CommonModule} from '@angular/common';
import { RouteReuseStrategy } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { SFSCommonModule, EntityListPageModule, SelectCompanyPageModule } from 'sfscommon';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { FormlyModule } from '@ngx-formly/core';
//import { FormlyIonicModule } from '@ngx-formly/ionic';
import { SharedModule } from './shared/shared.module';
import { RecaptchaModule, RecaptchaFormsModule } from 'ng-recaptcha';

import { MainMenuButtonModule } from './components/business/main-menu-button/main-menu-button.module';
import { AgmCoreModule } from '@agm/core';
import { FormlyWrapperAddons } from './components/business/components/addons-extension/addons-extension.component';
import { addonsExtension } from './components/business/components/formly-wrapper-addons/formly-wrapper-addons.component';
// Enviroment
import { environment } from 'src/environments/environment';
import { SocialLoginModule } from 'angularx-social-login';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';


@NgModule({
  declarations: [
    AppComponent,
    FormlyWrapperAddons
  ],
  entryComponents: [],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  exports: [
    SharedModule,
  ],
  imports: [

    // AgmCoreModule.forRoot({
    //   apiKey: 'AIzaSyCwlw3uJsHw732X1W3ScbjqjbR6JUxAE4M'
    //   /* apiKey is required, unless you are a 
    //   premium customer, in which case you can 
    //   use clientId 
    //   */
    // }),
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyCwlw3uJsHw732X1W3ScbjqjbR6JUxAE4M'
    }),
    MainMenuButtonModule,
    FormlyModule.forRoot({
      wrappers: [
        { name: 'addons', component: FormlyWrapperAddons },
      ],
      extensions: [
        { name: 'addons', extension: { onPopulate: addonsExtension } },
      ],
    }),
    BrowserAnimationsModule,
    SharedModule,
    MatExpansionModule,
    SocialLoginModule,
    MatGridListModule, MatCheckboxModule,
    IonicModule.forRoot(),
    SelectCompanyPageModule,
    SFSCommonModule.forRoot(environment.sfscommon),
    AppRoutingModule,
    EntityListPageModule,
    RecaptchaModule,
    RecaptchaFormsModule

  ],
  providers: [

    StatusBar,
    SplashScreen,
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

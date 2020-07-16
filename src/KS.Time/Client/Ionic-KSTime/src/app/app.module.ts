import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { SFSCommonModule, EntityListPageModule } from 'sfscommon';
import { environment } from 'src/environments/environment';
import { ReactiveFormsModule } from '@angular/forms';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { FormlyWrapperAddons } from './sfs/components/business/components/addons-extension/addons-extension.component';

@NgModule({
  declarations: [AppComponent,
    FormlyWrapperAddons],
  entryComponents: [],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
   
    MatExpansionModule,
    MatGridListModule, MatCheckboxModule,
    IonicModule.forRoot(),
   // SelectCompanyPageModule,
    SFSCommonModule.forRoot(environment.sfscommon),
    AppRoutingModule,
    EntityListPageModule,
    // RecaptchaModule,
    // RecaptchaFormsModule,
    ReactiveFormsModule,
    FormlyModule.forRoot(),
    FormlyMaterialModule
  ],
  providers: [
    StatusBar,
    SplashScreen,
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}

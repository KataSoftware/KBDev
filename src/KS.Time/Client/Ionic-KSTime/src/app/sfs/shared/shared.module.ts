import { GenericModalComponent } from './../generic/generic-modal/generic-modal.component';
import { UserMenuComponent } from './../components/business/user-menu/user-menu.component';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { CheckboxWrapperComponent } from './common/material/checkbox-wrapper';
import {MatMenuModule} from '@angular/material/menu';
import {MatInputModule} from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker';

import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { AuthGuardService } from '../services/AuthGuard.service';
import { FormlyFieldRatingComponent } from './common/FormlyFieldRating';
import { RatingWrapperComponent } from './common/material/rating-wrapper';

import { DatepickerTypeComponent } from './common/material/datepicker-type';
import {MAT_DATE_LOCALE, MatNativeDateModule} from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { BrowserModule } from '@angular/platform-browser';
import { ModalPage } from '../common/modal/modal.page';
import { HideHeaderDirective } from '../directives/hide-header.directive';
import { FormlyMatDatepickerModule } from '@ngx-formly/material/datepicker';


@NgModule({
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  declarations: [
    CheckboxWrapperComponent,
    UserMenuComponent,
    FormlyFieldRatingComponent,
    RatingWrapperComponent,
    DatepickerTypeComponent,
    ModalPage,
    GenericModalComponent,
    HideHeaderDirective
  ],
  entryComponents: [ModalPage, GenericModalComponent],
  providers: [
    AuthGuardService,
    { provide: MAT_DATE_LOCALE, useValue: 'es-MX'}
  ],
  imports: [
   
   // BrowserModule,
    FormsModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatMenuModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    FormlyMatDatepickerModule,
    ReactiveFormsModule,
    MatIconModule,
    FormlyModule.forRoot({
      types: [
        { name: 'rating', component: FormlyFieldRatingComponent, wrappers: ['rating-wrapper'] },
        {
          name: 'datepicker',
          component: DatepickerTypeComponent,
          wrappers: ['form-field'],
          defaultOptions: {
            defaultValue: new Date(),
            templateOptions: {
              datepickerOptions: {},
            },
          },
        }
      ],
      wrappers: [
        { name: 'checkbox-wrapper', component: CheckboxWrapperComponent },
        { name: 'rating-wrapper', component: RatingWrapperComponent },
   
      ],
    }),
    FormlyMaterialModule,
  ],
  exports: [
    CheckboxWrapperComponent,
    UserMenuComponent,
    HideHeaderDirective,
    GenericModalComponent
  ]

})

export class SharedModule { }
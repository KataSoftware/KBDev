import { UserMenuComponent } from './../components/business/user-menu/user-menu.component';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { CheckboxWrapperComponent } from './common/material/checkbox-wrapper';
import { MatButtonModule, MatButtonToggleModule, MatMenuModule, MatIconModule, MatMenu, MatInputModule, MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { AuthGuardService } from '../services/common/AuthGuard.service';
import { FormlyFieldRatingComponent } from './common/FormlyFieldRating';
import { RatingWrapperComponent } from './common/material/rating-wrapper';
//import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { ModalPage } from '../pages/common/modal/modal.page';
import { DatepickerTypeComponent } from './common/material/datepicker-type';
import {MAT_DATE_LOCALE} from '@angular/material';


@NgModule({
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  declarations: [
    CheckboxWrapperComponent,
    UserMenuComponent,
    FormlyFieldRatingComponent,
    RatingWrapperComponent,
    DatepickerTypeComponent,
    ModalPage,
  ],
  entryComponents: [ModalPage],
  providers: [
    AuthGuardService,
    { provide: MAT_DATE_LOCALE, useValue: 'es-MX'}
  ],
  imports: [

    CommonModule,
    FormsModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatMenuModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
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

  ]

})

export class SharedModule { }
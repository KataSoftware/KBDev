import { CheckboxWrapperComponent } from './material/checkbox-wrapper';
//import { FormlyFieldRating } from './FormlyFieldRating';
import { RatingWrapperComponent } from './material/rating-wrapper';
import { FormlyFieldRatingComponent } from './FormlyFieldRating';
import { FormlyFieldInput } from '@ngx-formly/ionic';

export function minlengthValidationMessage(err, field) {
  return `Debe tener al menos ${field.templateOptions.minLength} caracteres`;
}

export function maxlengthValidationMessage(err, field) {
  return `Debe tener máximo ${field.templateOptions.maxLength} caracteres`;
}

export function minValidationMessage(err, field) {
  return `Debe ser mayor a  ${field.templateOptions.min}`;
}

export function maxValidationMessage(err, field) {
  return `Debe ser menor a ${field.templateOptions.max}`;
}
export const FormlyConfig = {
  // wrappers: [
  //   { name: 'checkbox-wrapper', component: CheckboxWrapperComponent },
  //   { name: 'rating-wrapper', component: RatingWrapperComponent },
  // ],
  // types: [
  //   { name: 'rating', component: FormlyFieldRatingComponent,  },
  // ],
  validationMessages: [
    { name: 'required', message: 'Este campo es requerido' },
    { name: 'minlength', message: minlengthValidationMessage },
    { name: 'maxlength', message: maxlengthValidationMessage },
    { name: 'min', message: minValidationMessage },
    { name: 'max', message: maxValidationMessage },
  ],
};
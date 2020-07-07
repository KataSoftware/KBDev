import { Component, ViewChild } from '@angular/core';
import { FieldType } from '@ngx-formly/material';
import { MatInput } from '@angular/material/input';


@Component({
  selector: 'app-form-datepicker-type',
  template: `
    <input matInput
      [errorStateMatcher]="errorStateMatcher"
      [formControl]="formControl"
      [min]="to.minDate"
      [max]="to.maxDate"
      [matDatepicker]="picker"
      [matDatepickerFilter]="to.datepickerOptions.filter"
      [formlyAttributes]="field">
    <ng-template #matSuffix>
      <mat-datepicker-toggle [for]="picker"></mat-datepicker-toggle>
    </ng-template>
    <mat-datepicker #picker></mat-datepicker>
  `,
})
export class DatepickerTypeComponent extends FieldType {
  // Optional: only if you want to rely on `MatInput` implementation
  @ViewChild(MatInput) formFieldControl: MatInput;
}

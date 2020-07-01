import { Component, ViewChild, ViewContainerRef } from '@angular/core';
import { FieldWrapper } from '@ngx-formly/core';

@Component({
  selector: 'rating-wrapper',
  template: `
   
        <ng-container #fieldComponent> 
        </ng-container>
    
  `,
})
export class RatingWrapperComponent extends FieldWrapper {
  @ViewChild('fieldComponent', {read: ViewContainerRef}) fieldComponent: ViewContainerRef;
  //public labelHtml?:string=null;
}
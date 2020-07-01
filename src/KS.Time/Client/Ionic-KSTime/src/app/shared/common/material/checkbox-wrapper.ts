import { Component, ViewChild, ViewContainerRef } from '@angular/core';
import { FieldWrapper } from '@ngx-formly/core';

@Component({
  selector: 'checkbox-wrapper',
  template: `
   
        <ng-container #fieldComponent></ng-container><span innerHTML="to.label"></span>
    
  `,
})
export class CheckboxWrapperComponent extends FieldWrapper {
  @ViewChild('fieldComponent', {read: ViewContainerRef}) fieldComponent: ViewContainerRef;
  //public labelHtml?:string=null;
}
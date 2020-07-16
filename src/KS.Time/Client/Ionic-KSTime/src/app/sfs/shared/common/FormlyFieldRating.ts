import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit, ViewChild, TemplateRef, ElementRef } from '@angular/core';
import { FieldType, FormlyFieldConfig, FormlyConfig } from '@ngx-formly/core';


@Component({
 selector: 'formly-field-rating',
 template: `
 <input type="hidden" onchange="to.change && to.change(field, $event)" [formControl]="formControl" [formlyAttributes]="field">
 <table class='rating'>
 
 <tr><td class='stars'>
 <ion-buttons>
<ion-button   class='star'  fill="clear" (click)="rate(1, $event)">
<ion-icon slot="icon-only" *ngIf=" model['Weight'] == null || model['Weight'] >= 1" name="star"></ion-icon>

</ion-button>
<ion-button  class='star' fill="clear" (click)="rate(3, $event)">
  <ion-icon slot="icon-only" *ngIf=" model['Weight'] >= 3" name="star"></ion-icon>
  <ion-icon slot="icon-only"  *ngIf="model['Weight'] == null || model['Weight'] < 3"name="star-outline" ></ion-icon>
</ion-button>
<ion-button  class='star'  fill="clear" (click)="rate(5, $event)">
<ion-icon slot="icon-only" *ngIf="  model['Weight'] >= 5" name="star"></ion-icon>
<ion-icon slot="icon-only"  *ngIf="model['Weight'] == null || model['Weight'] < 5"name="star-outline" ></ion-icon>
</ion-button>
<ion-button  class='star' fill="clear" (click)="rate(7, $event)">
<ion-icon slot="icon-only" *ngIf="  model['Weight'] >= 7" name="star"></ion-icon>
<ion-icon slot="icon-only"  *ngIf="model['Weight'] == null || model['Weight'] < 7"name="star-outline" ></ion-icon>
</ion-button>
<ion-button  class='star' fill="clear" (click)="rate(9, $event)">
<ion-icon slot="icon-only" *ngIf=" model['Weight'] >= 9" name="star"></ion-icon>
<ion-icon slot="icon-only"  *ngIf="model['Weight'] == null || model['Weight'] < 9"name="star-outline" ></ion-icon>
</ion-button>
</ion-buttons>
</td></tr></table>
 `,
})
export class FormlyFieldRatingComponent extends FieldType implements OnInit  {
   // model['Weight']:number = 0;
    rate(rate: number , event){
      this.formControl.setValue(rate);
      this.formControl.patchValue(rate);
      // this  .field.formControl.patchValue(rate);;
      //   this.model['Weight'] = rate;
      //  console.log(this.to);
       // console.log(this.to.change);
        this.model["Weight"] = rate;
    }
    ngOnInit() {  
        //this.model['Weight'] = this.model["Weight"];

      }

}
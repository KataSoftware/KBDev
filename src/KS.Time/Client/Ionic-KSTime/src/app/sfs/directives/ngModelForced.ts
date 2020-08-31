import { NgModel } from '@angular/forms';
import { Directive, OnInit } from '@angular/core';

@Directive({
    selector: '[ngModelForced]',
    providers: [NgModel]
  })
  export class NgModelForced implements OnInit{
  
    constructor(
      private ngModel: NgModel
    ) { }
  
    ngOnInit(): void {
      console.log(this.ngModel);
    }
  
  }
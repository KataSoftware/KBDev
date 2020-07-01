import { Component, OnInit, Input, NgModule, Self, Optional } from '@angular/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import { ControlValueAccessor, NgControl } from '@angular/forms';

@Component({
  selector: 'sfs-field',
  templateUrl: './sfsfield.component.html',
  styleUrls: ['./sfsfield.component.scss'],
})
//

export class SFSFieldComponent implements OnInit, ControlValueAccessor {
  private onChange: Function = (randomNumber: number) => {};
  private onTouch: Function = () => {};
  @Input() disabled: boolean;
  @Input() label: string;
  @Input() placeholder: string = '';
  @Input() type: 'text' | 'email' | 'password' = 'text';

  value: any = '';
  writeValue(obj: any): void {
    this.onChange(obj);
    this.value = obj;
    console.log("writeValue ");
  }
  registerOnChange(fn: any): void {
    this.onChange = fn;
  }
  registerOnTouched(fn: any): void {
    this.onTouch = fn; 
  }
  setDisabledState?(isDisabled: boolean): void {
    this.disabled = isDisabled;
  }

  
  @Input() ProviderType:string;
  @Input() ItemClass:any;
  

  
  private _ControlClass : any;
  @Input() 
  public get ControlClass() : any {
    return this._ControlClass;
  }
  public set ControlClass(v : any
) {
      this._ControlClass = v;
  }
  

  @Input() LabelClass:any;

  constructor(
    @Self()
    @Optional()
    private ngControl: NgControl
  ) { }

  ngOnInit() {}

}

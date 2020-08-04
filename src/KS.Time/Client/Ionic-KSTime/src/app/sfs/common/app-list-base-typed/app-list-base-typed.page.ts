import { Component, Injector } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { AppListBasePage } from '../app-list-base/app-list-base.page';

export class AppListBaseTypedPage<T> extends AppListBasePage {

  
  constructor(public injector:Injector) {
    super(injector);
  }

  applyFilter(page:any, e:any){

  }
  onGetData(data:any){
   // console.log("data", data);
  }
  
  selection = new SelectionModel<T>(true, []);

  isAllSelected() {
    if (this.selection != null && this.selection.selected != null && this.data != null){
    const numSelected = this.selection.selected.length;
    const numRows = this.data.length;
    return numSelected === numRows;
    }else{
        return false;
    }
  }
  
  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
        this.selection.clear() :
        this.data.forEach(row => this.selection.select(row));
  }
  
  

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?:any): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row `;
  }

  

}

export class FieldConfig{
  name:string=null;
  data:any[];
  required:boolean=false;

}
import { PageService } from '../../services/page.service';
import { OnInit, Injector, Component } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { BasePage } from 'sfscommon';
import { FieldSettings, DialogButton } from '../../models/common/page.model';
import { AppFormBasePage } from '../app-form-base/app-form-base.page';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.page.html',
  styleUrls: ['./modal.page.scss'],
})
export class ModalPage extends BasePage implements OnInit {
  fieldsSet: Array<FieldSettings> = [];
  item:any={};
  title:string=null;
  cssClass?:string=null;
  form: FormGroup;
  fields: Array<FormlyFieldConfig> = [];
  showCancel:boolean=true;
  primaryButtonText:string="Guardar";
  constructor(public injector: Injector, public pageService:PageService) { 
    super(injector);
    
    this.form = new FormGroup({});
    this.theHtmlString = this.navParams.get("contentHtml");
    this.buttons = this.navParams.get("buttons");
    this.dialogType = this.navParams.get("dialogType");
    this.fieldsSet = this.navParams.get("fields");
    this.item = this.navParams.get("item");
    this.title = this.navParams.get("title");
    if (this.navParams.get("hideCancel")  != null ){
      if(this.navParams.get("hideCancel") == true){
        this.showCancel = false;
      }
    } 
    if (this.navParams.get("primaryButtonText")  != null ){
      this.primaryButtonText = this.navParams.get("primaryButtonText");
    } 
    this.createFormlyFields();
    if (this.fieldsSet != null ){
      this.fieldsSet.forEach(element => {
        this.pageService.setOrder(element, this.fields);
      });
    }
  }

  createFormlyFields(){
    let field:FormlyFieldConfig= {};  
    if (this.fieldsSet != null ){
    this.fieldsSet.forEach(element => {
      field = {
        key: element.Name,
        type: 'input',
    
        templateOptions: {
            label: element.Label,
            placeholder: '',
            required: false,
        
        maxLength: 255,
        }
      };
      this.fields.push(field);
    });
    }
  }

  dialogType:string="ok";
  buttons:Array<DialogButton>=[];
  theHtmlString:string=null;
  close(){
    this.modalCtrl.dismiss(null,null);
  }
  submitForm(event){
    
    this.modalCtrl.dismiss(this.form.value, event);
  }


  ngOnInit() {
    this.pageService.showForm(this.fields);
  }

}

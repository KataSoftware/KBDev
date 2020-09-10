import { FormlyFieldConfig } from '@ngx-formly/core';
import { Observable } from 'rxjs/internal/Observable';

export enum FieldTypes {
    Password = "password",
    Currency = "currency",
    String = "string",
    Time = "time",
    Number = "number"
  }
  export enum ControlTypes {
    Input = "input",
    Checkbox = "checkbox",
    Custom = "custom",
    Hidden = "hidden",
    
  
  }
  export enum MobileFieldPlace{
    Principal=1,
    Value=2,
    Secondary=3,
    Summary=4
  }
  export class ChildRelation {
    public Name?:string;
    public FkPropertyName?:string;
    public FkRelationName?:string;
    public Label?:string;
    public EntityName?:string;
    public Order?:number;

  }
  export class FieldSettings {
    public Fields?: Array<FormlyFieldConfig> = null;
    public Id?: string = null;
    public Place?:MobileFieldPlace = null; 
    public Num?: number = null;
    public Name?: string = null;
    public Content?: string = null;
    public ClassName?: string = null;
    public HideExpression?: any = null;
    public ClassNameGroup?: string = null;
    public TemplateOptions?: any = null;
    public ReadOnly?: boolean = null;
    public ExpressionProperties?: any = null;
    public Type?: FieldTypes = null;
    public IsMultiLine?: boolean = false;
    public ControlType?: ControlTypes = null;
    public CustomControl?: string = null;
    public Validators?: any = null;
    public AsyncValidators?: any = null;
    public Required?: boolean | any = false;
    public Columns?: number = 12;
    public Percent?: number;
    public Label?: string;
    public LabelHtml?: string;
    public Hooks?: any;
    public AttColor?:any;
    public OnChange?= (field, event) => { };
    public OnKeyUp?= (field, event) => { }
    public PlaceHolder?: string;
    public EntityModel?: any = null;
    public DataQuery?: string = null;
    public Data?: any[] | Observable<any[]>;
    public DataValue?: string = null;
    public DataText?: string = null;
    public MinLength?: number = null;
    public MaxLength?: number = null;
    public Min?: number = null;
    public Max?: number = null;
    public Wrapper?: string = null;
    public IsFilter?:boolean=null;
    public IsFilterRange?:boolean=null;
  }
  
  export class SeparatorSettings {
    public Title?: string = null;
    public Content?: string = null;
  }
  export class DialogButton {
    CssClass?: string;
    ActionKey?: string;
    Text?: string;
    Click = (modalPage: any, action: string) => { };
  }
  export class DialogSettings {
    /**
     *
     */
    constructor() {
  
  
    }
    Title?: string;
    Message?: string;
    HideCancel?:boolean=false;
    PrimaryButtonText?:string=null;
    Data?: any = null;
    OnClose?= (data, event) => { };
    CssClass?:string;
    Fields?: Array<FieldSettings> = [];
    Type?: string;
    Buttons?: Array<DialogButton> | any;
    SetField?= (field: FieldSettings) => {
      this.Fields.push(field);
    }
  }
  
  
  export class BackToListSettings {
    RestartPaging?: Boolean = false;
    ItemUpdated?: any = null;
    Route?: string = null;
    RefreshData?: boolean = false;
  }
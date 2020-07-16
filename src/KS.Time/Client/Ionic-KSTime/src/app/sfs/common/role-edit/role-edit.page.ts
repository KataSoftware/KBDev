import { BooleanNullable } from '../../models/common/utils';
import { Component, OnInit, Injector } from '@angular/core';
import { BasePage, StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, AbstractControl, FormControl, Validators } from '@angular/forms';
import { sfsService } from '../../services/sfs.service';
import { secRoleModel } from '../../models/common/system-models';

@Component({
  selector: 'app-role-edit',
  templateUrl: './role-edit.page.html',
  styleUrls: ['./role-edit.page.scss'],
})
export class RoleEditPage extends BasePage implements OnInit {
  loadingData: boolean = true;
  guidRole: string = null;
  form: FormGroup;
  defaultHref:string=null;
  public get role(): FormGroup { return <FormGroup>this.form.get('Role'); }
  public get roleName(): AbstractControl { return <AbstractControl>this.form.get('Role.RoleName'); }
  public get nameKey(): AbstractControl { return <AbstractControl>this.form.get('Role.NameKey'); }
  public get isFullAccessControl(): AbstractControl { return <AbstractControl>this.form.get('Role.IsFullAccessControl'); }

  isFullAccessOptions:Array<BooleanNullable> =  BooleanNullable.GetOptions();
  activatingText: string = 'Guardar';
  disabledButton: boolean = false;
  textoModal: string = "ssdsfs";
  roleNameInUse: boolean;
  nameKeyInUse: boolean;
  roleNameInitial: string = null;
  nameKeyInitial: string = null;
  constructor(public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService) {
    super(injector);
    this.title = 'Detalle de rol';

    this.form = new FormGroup({
      Role: new FormGroup({
        RoleName: new FormControl('', [Validators.required]),
        NameKey: new FormControl(''),
        IsFullAccessControl:new FormControl('')
      })
    });

    this.guidRole = this.route.snapshot.paramMap.get('guidRole');
    this.defaultHref = `system/roles`;
  }

  async ngOnInit() {
    this.getData();

  }
  async getData() {
    let role: secRoleModel = null;

    if (this.guidRole != null) {

      let result = await this.sfsService.GetItem(this.guidRole, secRoleModel._EntitySetName);
      if (result.status == "success") {
        role = result.data;
        if (role != null) {
          this.roleNameInitial = role.RoleName;
          this.nameKeyInitial = role.NameKey;

          this.roleName.setValue(role.RoleName);
          this.nameKey.setValue(role.NameKey);
          console.log("test x22", role.IsFullAccess);
          this.isFullAccessControl.setValue(BooleanNullable.BooleanToOption(role.IsFullAccess));
          
        }
      }
    }
  }
  async  roleNameAvailable() {
    if (this.roleNameInitial == this.roleName.value) {
      this.roleNameInUse = false;
    } else {
      let result = await this.sfsService.CustomMethod({ roleName: this.roleName.value }, "secRoles", "RoleNameAvailable");

      this.roleNameInUse = result.data == false;
    }
  }
  async  roleNameKeyAvailable() {
    if (this.nameKeyInitial == this.nameKey.value) {
      this.nameKeyInUse = false;
    } else {
      let result = await this.sfsService.CustomMethod({ nameKey: this.nameKey.value }, "secRoles", "RoleNameKeyAvailable");

      this.nameKeyInUse = result.data == false;
    }
  }
  async goBack() {


    this.navCtrl.navigateForward(`system/roles`, { animated: true });

  }

  async saveData() {
    console.log("saving");

    if (this.form.valid == true) {
      this.activatingText = 'Guardando...';
    this.disabledButton = true;
    this.loadingData = true;
    console.log("form value", this.form.value.Role);
      const role: secRoleModel = this.form.value.Role;
      role.GuidRole = this.guidRole;
      let isFullAccessValue = this.isFullAccessControl.value
      console.log("isFullAccessValue",isFullAccessValue);
      role.IsFullAccess = BooleanNullable.OptionToBoolean(isFullAccessValue);

      let apiResponse: ApiResponse<any> = null;

      if (this.guidRole != null) {


        apiResponse = await this.sfsService.Update(role, secRoleModel._EntitySetName, "RoleName,NameKey,IsFullAccess");

      } else {

        apiResponse = await this.sfsService.Create(role, secRoleModel._EntitySetName);

      }

      if (apiResponse.status == 'success') {


        this.loadingData = false;
        this.activatingText = 'Guardado';
        this.disabledButton = false;


      
        

        this.goBack();
      }
    }
  }
}

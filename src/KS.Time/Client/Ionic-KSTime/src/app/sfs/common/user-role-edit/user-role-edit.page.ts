import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { BasePage, StorageService, UserService, ApiResponse } from 'sfscommon';

import { FormGroup, AbstractControl, FormControl, Validators } from '@angular/forms';
import { secUserCompanyModel, secUserModel, secRoleModel } from '../../models/common/system-models';
import { sfsService } from '../../services/sfs.service';


// Third Library Imports


@Component({
  selector: 'app-user-role-edit',
  templateUrl: './user-role-edit.page.html',
  styleUrls: ['./user-role-edit.page.scss'],
})
export class UserRoleEditPage extends BasePage implements OnInit {
  loadingData: boolean = true;
  guidItem: string = null;
  form: FormGroup;
  item: secUserCompanyModel;
  emailRegistered: boolean = false;
  user: secUserModel = null;
  activatingText: string = 'Guardar';
  disabledButton: boolean = false;
  textoModal: string = "ssdsfs";
  roles: Array<secRoleModel> = [];
  users: Array<secUserModel> = [];
  //guidUser:string=null;
  submitAttempt: boolean = false;
  guidUserFrom: string = null;
  @ViewChild("ionItemGuidRole") public ionItemGuidRole: HTMLElement;

  public get userRole(): FormGroup { return <FormGroup>this.form.get('UserRole'); }
  public get email(): AbstractControl { return <AbstractControl>this.form.get('UserRole.Email'); }
  public get firstName(): AbstractControl { return <AbstractControl>this.form.get('UserRole.FirstName'); }
  public get lastName(): AbstractControl { return <AbstractControl>this.form.get('UserRole.LastName'); }
  public get guidRole(): AbstractControl { return <AbstractControl>this.form.get('UserRole.GuidRole'); }
  public get guidUser(): AbstractControl { return <AbstractControl>this.form.get('UserRole.GuidUser'); }
  public get password(): AbstractControl { return <AbstractControl>this.form.get('UserRole.Password'); }

  GuidRole: string = null;
  GuidUser: string = "00000000-0000-0000-0000-000000000000";
  defaultHref: string;

  constructor(public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService

  ) {

    super(injector);
    this.title = 'Detalle de relación rol y usuario';


    if (this.guidUserFrom != null) {
      this.form = new FormGroup({
        UserRole: new FormGroup({

          GuidRole: new FormControl(null, [Validators.required]),

        })
      });
    } else {
      this.form = new FormGroup({
        UserRole: new FormGroup({
          Email: new FormControl('', [Validators.required, Validators.email]),
          FirstName: new FormControl('', [Validators.required]),
          LastName: new FormControl('', [Validators.required]),
          GuidRole: new FormControl(null, [Validators.required]),
          GuidUser: new FormControl(null),
          Password: new FormControl(null),
        })
      });
    }
    this.defaultHref = '/system/users-roles';
    this.guidItem = this.route.snapshot.paramMap.get('guidUserCompany');
    this.guidUserFrom = this.route.snapshot.paramMap.get('guidUser');

  }


  async ngOnInit() {
    this.getData();
    //this.getRoles();

    if (this.guidUserFrom != null) {

      let userResponse = await this.sfsService.CustomMethod({ "guidUser": this.guidUserFrom }, "secUsers", "GetUser");



      this.getRoles(this.guidUserFrom);

      if (userResponse.status == "success") {
        if (userResponse.data != null) {
          this.email.setValue(userResponse.data.Email);
          this.user = userResponse.data;
          this.GuidUser = this.user.GuidUser;
          this.guidUser.setValue(this.user.GuidUser);
          this.firstName.setValue(this.user.FirstName);
          this.lastName.setValue(this.user.LastName);
          this.users.push(this.user);
        }
      }
    }
  }

  async touch(x) {
    this.ionItemGuidRole.className = this.ionItemGuidRole.className + " ion-touched";
    console.log(x);
  }
  async getRoles(guidUser?: string) {
    let response =  await this.sfsService.Get({ EntitySet: secRoleModel._EntitySetName, Usemode: "roles-admin-app-for-use" });
    if (response.isSuccess()) {
      this.roles = response.data;
      let userData = await this.userService.getUserData();
      let currentRolesResponse: ApiResponse<any> = null;
      if (guidUser != null) {
        currentRolesResponse = await this.sfsService.CustomMethod({ "guidUser": guidUser }, "secRoles", "GetRolesOfUser");

      } else {
        currentRolesResponse = await this.sfsService.CustomMethod({}, "secRoles", "GetRolesOfUser");

      }
      if (currentRolesResponse.status == "success") {
        currentRolesResponse.data.forEach(element => {
          this.roles.splice(this.roles.findIndex(p => p.GuidRole == element.GuidRole), 1);
        });
      }

    } else {
      this.roles = [];
    }
  }
  /* async getUsers(){
    let response  = await <ApiResponse<Array<secUserModel>>>this.sfsService.Get({ EntitySet: secUserModel._EntitySetName, Usemode: "roles-admin-app"  });
    if (response.status === "success" ){
      this.users = response.data;
    }else{
      this.roles = [];
    }
  } */


  public hasError = (controlName: string, errorName: string) => {
    return this.form.controls[controlName].hasError(errorName);
  }

  async getData() {
    //let user:secUserCompanyModel  = null;
    console.log("guidItem", this.guidItem);
    if (this.guidItem != null) {

      let result = await this.sfsService.GetItem(this.guidItem, secUserCompanyModel._EntitySetName);

      if (result.status == "success") {
        this.item = result.data;
        if (this.item != null) {
          this.GuidRole = this.item.GuidRole;
          this.GuidUser = this.item.GuidUser;

          this.email.setValue(this.item.Email);
          this.firstName.setValue(this.item.FirstName);
          this.lastName.setValue(this.item.LastName);
          this.guidRole.setValue(this.item.GuidRole);
          this.guidUser.setValue(this.item.GuidUser);
        }
      }
    }
  }
  async  isEmailRegistered() {
    if (this.guidUserFrom == null) {
      const response = await this.sfsService.CustomMethod({ email: this.email.value }, secUserModel._EntitySetName, "GetUserByEmail");
      if (response.status == "success" && response.data != null) {
        this.user = response.data;
        this.GuidUser = this.user.GuidUser;
        this.guidUser.setValue(this.user.GuidUser);
        this.firstName.setValue(this.user.FirstName);
        this.lastName.setValue(this.user.LastName);
        this.users.push(this.user);
      } else {
        this.user = null;
        this.GuidUser = "00000000-0000-0000-0000-000000000000";
        this.guidUser.setValue(null);
        this.firstName.setValue(null);
        this.lastName.setValue(null);
        this.password.setValue(null);
        this.users = [];
      }
    }
  }
  async changeRole(event) {

  }
  async goBack() {

    if (this.guidUserFrom  != null){
      this.navCtrl.navigateForward(`system/users-roles/user/${this.guidUserFrom}`, { animated: true });
    }else{
      this.navCtrl.navigateForward(`system/users-roles`, { animated: true });
    }
    

  }

  async saveData() {
    this.submitAttempt = true;

    this.activatingText = 'Guardando...';
    this.disabledButton = true;
    this.loadingData = true;


    if (this.form.valid == true) {
      let userData = await this.userService.getUserData();

      this.item = this.form.value.UserRole;
      this.item.GuidUserCompany = this.guidItem;
      this.item.GuidCompany = userData.IdCompany;
      this.item.AppNameKey = "KSTime";
      this.item.SetInitialData = true;
      if (this.item.GuidUser == null) {
        this.item.GuidUser = "00000000-0000-0000-0000-000000000000";
      }
      // user.UserName = user.Email;
      // user.GuidUser = this.guidUser;
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {


        apiResponse = await this.sfsService.Update(this.item, secUserCompanyModel._EntitySetName, "GuidUser,GuidRole");

      } else {

        apiResponse = await this.sfsService.Create(this.item, secUserCompanyModel._EntitySetName);

      }

      if (apiResponse.status == 'success') {


        this.loadingData = false;
        this.activatingText = 'Guardado';

       
        
        this.goBack();
      }
    }
  }

}

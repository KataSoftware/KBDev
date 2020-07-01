import { Component, OnInit, Injector } from '@angular/core';
import { StorageService, UserService, BasePage, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators, FormArray, AbstractControl } from '@angular/forms';
import { secUserModel } from 'src/app/models/common/system-models';
import { sfsService } from 'src/app/services/common/sfs.service';

// Third Library Imports
import swal from 'sweetalert';

@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.page.html',
  styleUrls: ['./user-create.page.scss'],
})
export class UserCreatePage extends BasePage implements OnInit {

  defaultHref: string;
  
  loadingData: boolean = true;
  guidUser: string = null;
  form: FormGroup;
  public get user(): FormGroup { return <FormGroup>this.form.get('User'); }
  public get email(): AbstractControl { return <AbstractControl>this.form.get('User.Email'); }
  public get firstName(): AbstractControl { return <AbstractControl>this.form.get('User.FirstName'); }
  public get lastName(): AbstractControl { return <AbstractControl>this.form.get('User.LastName'); }

  public get password(): AbstractControl { return <AbstractControl>this.form.get('User.Password'); }



  activatingText: string = 'Guardar';
  disabledButton: boolean = false;
  textoModal: string=null;
  emailInUse: boolean;

  constructor(public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService

  ) {
    super(injector);
    this.title = 'Información del cliente';

    this.form = new FormGroup({
      User: new FormGroup({
        Email: new FormControl('', [Validators.required, Validators.email]),
        FirstName: new FormControl('', [Validators.required]),
        LastName: new FormControl('', [Validators.required]),
        //Password: new FormControl(null),
      })
    });

    this.guidUser = this.route.snapshot.paramMap.get('guidUser');
    console.log("ctor guidUser", this.guidUser);
    this.defaultHref = "system/users";
  }

  async ngOnInit() {
    this.getData();

  }
  initialEmail:string = null ;
  async getData() {
    let user: secUserModel = null;
    console.log("guidUser", this.guidUser);
    if (this.guidUser != null) {
      
      let response = await this.sfsService.GetItem(this.guidUser, secUserModel._EntitySetName);

      if (response.status == "success") {
        user = response.data;
        
        if (user != null) {
          this.initialEmail =  user.Email;
          this.email.setValue(user.Email);
          this.firstName.setValue(user.FirstName);
          this.lastName.setValue(user.LastName);
         // this.password.setValue(user.Password);
        }
      }
    }
  }
  async  emailAvailable() {
    if (this.guidUser != null && this.initialEmail != this.email.value){
      this.emailInUse = await this.sfsService.IsEmailAvailable(this.email.value) === false;
      console.log("emailin use", this.emailInUse);
    }else{
      this.emailInUse = false;
    }
  }
  async goBack() {


    this.navCtrl.navigateForward(`system/users`, { animated: true });

  }

  async saveData() {
    this.activatingText = 'Guardando...';
    this.disabledButton = true;
    this.loadingData = true;

    if (this.form.valid == true) {
      const user: secUserModel = this.form.value.User;
      user.UserName = user.Email;
      user.GuidUser = this.guidUser;
      let apiResponse: ApiResponse<any> = null;

      if (this.guidUser != null) {


        apiResponse = await this.sfsService.Update(user, secUserModel._EntitySetName, "Email,UserName,FirstName,LastName");

      } else {

        apiResponse = await this.sfsService.Create(user, secUserModel._EntitySetName);

      }

      this.loadingData = false;
      this.activatingText = 'Guardado';
      this.disabledButton = false;
      if (apiResponse.status == 'success') {


       

        const response = await swal({
          title: 'Registro exitoso',
          className: 'swal-ok-modal',
          text: this.textoModal,
          buttons: {
            confirmar: {
              text: 'Continuar',
              value: true,
              visible: true,
              className: 'modal-continuar-button',
              closeModal: true
            }
          }
        });

        this.goBack();
      }
    }
  }
}

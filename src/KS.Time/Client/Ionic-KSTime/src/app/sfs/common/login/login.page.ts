import { sfsService } from '../../services/sfs.service';
// Angular Imports
import { Component, Injector } from '@angular/core';

// SFSCommon
import { LoginPage, AuthenticationService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators, AbstractControl, Form } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';


import { FormlyFieldConfig } from '@ngx-formly/core';
import { RegisterModel } from '../../models/common/models';

@Component({
  selector: 'login-page',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LocalLoginPage extends LoginPage {
  height: number = 0;
  fields: Array<FormlyFieldConfig> = [];
  isRecoveryPassword: boolean = false;
  public activatingText: string = 'Guardar';
  public disabledButton: boolean = false;
  public textoModal: string = "Title";
  public loadingData: boolean = true;
  public submitButtonText: string = 'Iniciar sesión';
  public submitButtonDisabled: boolean = false;
  public appLogo: string = './assets/images/logo-home.png';
  public getControl(name: string): AbstractControl {
    return <AbstractControl>this.form.get(name);
  }
  public getFormGroup(name: string): FormGroup {
    return <FormGroup>this.form.get(name);
  }
  public getLoginControl(name: string): AbstractControl {
    return <AbstractControl>this.formlogin.get(name);
  }
  public getLoginFormGroup(name: string): FormGroup {
    return <FormGroup>this.formlogin.get(name);
  }
  public getSetPasswordControl(name: string): AbstractControl {
    return <AbstractControl>this.formsetpassword.get(name);
  }
  public getSetPasswordFormGroup(name: string): FormGroup {
    return <FormGroup>this.formsetpassword.get(name);
  }
  formlogin: FormGroup;
  formsetpassword: FormGroup;
  formActivateAccount: FormGroup;
  isSetPassword: boolean = false;
  isActivateAccount: boolean =  false;
  isLogin:boolean =false;
  email: string = null;
  code: string = null;

  //form = new FormGroup({});
  model:RegisterModel = { Email: '' };

  notFields(keys:string[], fields:Array<FormlyFieldConfig> ){
    let elementsForRemove : Array<FormlyFieldConfig> = [];

    for (let index = 0; index < keys.length; index++) {
       let finded = fields.find(p=> p.key == keys[index]);
      if (finded != null ){
        elementsForRemove.push(finded);
      }
    }
    
   // finded = fields.find(p=> p.key == )
    
    return fields.filter(p => !elementsForRemove.includes(p) );
  }
  onlyFields(keys:string[], fields:Array<FormlyFieldConfig> ){
    let elementsFinded : Array<FormlyFieldConfig> = [];

    for (let index = 0; index < keys.length; index++) {
       let finded = fields.find(p=> p.key == keys[index]);
      if (finded != null ){
        elementsFinded.push(finded);
      }
    }
    
    return elementsFinded;
   // finded = fields.find(p=> p.key == )
    
    //eturn fields.filter(p => !elementsForRemove.includes(p) );

  }
  return: string = '';
  isMobile:boolean=false;
  constructor(public injector: Injector, public authService: AuthenticationService, public sfsService: sfsService,  public router: Router,
    public route: ActivatedRoute) {
    super(injector, authService);
    this.form = new FormGroup({});
      this.model = new RegisterModel();
    this.urlLogo = '';
    if (this.router.url.indexOf("recovery-password") != -1) {
      this.isRecoveryPassword = true;
    }
    if (this.router.url.indexOf("set-password") != -1) {
      this.code = this.route.snapshot.paramMap.get("code");
      this.email = this.route.snapshot.paramMap.get("email");
      this.isSetPassword = true;
    }
    if (this.router.url.indexOf("activate-account") != -1) {
      this.code = this.route.snapshot.paramMap.get("code");
      this.email = this.route.snapshot.paramMap.get("email");
      this.isActivateAccount = true;
    }
    if (this.router.url.indexOf("login") != -1) {
      // this.code = this.route.snapshot.paramMap.get("code");
      // this.email = this.route.snapshot.paramMap.get("email");
      this.isLogin = true;
    }
   

    this.fields = [{
      key: 'Email',
      type: 'input',
      templateOptions: {
        label: 'Email',
       // placeholder: 'Escribe tu correo',
        required: true,
      }
    },
    {
      key: 'Password',
      type: 'input',
      templateOptions: {
        label: 'Contraseña',
        //placeholder: 'Escribe tu contraseña',
        required: true,
        type: "password",
      },
      validators: 
      { 
          email: 
          {
          expression: (control)=> {
            if (this.router.url.startsWith("/login") == false){
              return (control.value != null && control.value != "") ? /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,30}$/.test(control.value) : true 
            }else{
              return true;
            }
          },
          message: 'Contraseña no válida',
          } 
      } 
    },
    {
      key: 'RepeatPassword',
      type: 'input',
      templateOptions: {
        label: 'Repite la contraseña',
        //placeholder: 'Escribe tu contraseña',
        required: true,
        type: "password",
      },
      validators:  { fieldMatch: {

        expression: (control) =>{ 
           
            return  control.value == this.model.Password },
        message: 'Password Not Matching',
      } },
    }
  
  ];

    if (this.isSetPassword == false && this.isRecoveryPassword == true){
      
        this.fields = this.onlyFields(["Email"], this.fields);
    
      
    }else if(this.isSetPassword == true && this.isRecoveryPassword == false){
      this.formsetpassword = new FormGroup({}); 
      this.fields = this.notFields(["Email"], this.fields);
      this.fields = this.onlyFields(["Password", "RepeatPassword"], this.fields);
      //this.submitButtonText = "Activar cuenta";
    }else if(this.isActivateAccount == true ){
      this.formActivateAccount = new FormGroup({}); 
      this.fields = this.notFields(["Email"], this.fields);
      this.fields = this.notFields(["Password","RepeatPassword"], this.fields);
      //this.submitButtonText = "Activar cuenta";
    }else{
     
      this.formlogin =  new FormGroup({}); 
      this.fields = this.onlyFields(["Email","Password"], this.fields);
    }


  }
  public form: FormGroup;

  recoveryPasswordShow() {

  }
  public savingStart() {
    this.activatingText = 'Guardando...';
    this.disabledButton = true;
    this.loadingData = true;
  }
  public savingEnd() {
    this.loadingData = false;
    this.activatingText = 'Guardado';
    this.disabledButton = false;
    this.loadingData = true;
  }

  public goToRecoveryPassword() {
    this.navCtrl.navigateForward(`recovery-password`, { animated: true });
  }

  public goToLogin() {
    this.navCtrl.navigateForward(`login`, { animated: true });
  }

  public async showOk(message?: string) {
    // const response = await swal({
    //   title: null,
    //   className: 'swal-ok-modal',
    //   text: message,
    //   buttons: {
    //     confirmar: {
    //       text: 'Continuar',
    //       value: true,
    //       visible: true,
    //       className: 'modal-continuar-button',
    //       closeModal: true
    //     }
    //   }
    // });

    // return response;
  }
  async goBack() {
    this.navCtrl.navigateForward(`login`, { animated: true });
  }

  public async handelLoginToSFS() {

    try {

      this.submitButtonText = 'Iniciando sesión...';
      this.submitButtonDisabled = true;
      if (this.formlogin.valid == true) {
        //let userData = await this.userService.getUserData();
        let item = this.formlogin.value;
        item["Username"] = item.Email;
        // Se hace la peticion al servidor.
        const response = <ApiResponse>await this.sfsService.loginToSFSApp(this.formlogin.value);

        // Existe respuesta.
        if (response) {

          // La respuesta fue exitosa.
          if (response.status == 'success') {

            this.userLoged(response.data);
            if (this.return != null ){
                this.router.navigateByUrl(this.return);
            }
          } else {
            this.showOk("No fue posible autenticar al usuario");
            // Error en la petición.
            //this.handleLoginError(response.reason);
          }
        }
      }
    } catch (error) {
      // this.httpErrorResponse(error); 
      console.error('handelLoginToSFS', error);
    }
    finally {
      this.submitButtonText = 'Iniciar sesión';
      this.submitButtonDisabled = false;
    }
  }

  async setActivateAccount(){
    this.savingStart();
    if (this.formActivateAccount.valid == true) {
      //let userData = await this.userService.getUserData();
      let item = this.formActivateAccount.value;


      let apiResponse: ApiResponse<any> = null;

      apiResponse = await this.sfsService.ActivateAccount(this.email, this.code, "KSTime");
      this.savingEnd();
      if (apiResponse.status == 'success') {

        await this.showOk(`La cuenta ha sido activada`);
        this.goBack();
      } else {
        this.showToastMessage("Hubo un error al activar la cuenta, intente más tarde por favor.");
      }
    }
  }

  async setPassword() {
    this.savingStart();
    if (this.formsetpassword.valid == true) {
      //let userData = await this.userService.getUserData();
      let item = this.formsetpassword.value;


      let apiResponse: ApiResponse<any> = null;

      apiResponse = await this.sfsService.SetPassword(this.email, this.code, item.Password, "KSTime");
      this.savingEnd();
      if (apiResponse.status == 'success') {

        await this.showOk(`La contraseña ha sido establecida`);
        this.goBack();
      } else {
        this.showToastMessage("Hubo un error al tratar de establecer la contraseña, intente más tarde por favor.");
      }
    }
  }
async goToRegister(){
  this.navCtrl.navigateForward(`register-client`, { animated: true });
}
  async recoverPassword() {
    this.savingStart();
    if (this.form.valid == true) {
      //let userData = await this.userService.getUserData();
      let item = this.form.value;


      let apiResponse: ApiResponse<any> = null;

      apiResponse = await this.sfsService.RecoveryPassword(item.Email, "KSTime");
      this.savingEnd();
      if (apiResponse.status == 'success') {

        await this.showOk(`Se ha enviado a su correo ${item.Email} el link para reestablecer su contraseña`);
        this.goBack();
      } else {
        this.showToastMessage("No fue posible enviar el correo electrónico a la dirección especificada");
      }
    }
  }


  ngOnInit() {
    if (window.innerWidth < 540){

      this.isMobile = true;
    }else{
      this.isMobile = false;
    }
    
    this.route.queryParams
    .subscribe(params => this.return = params['return']);
    this.events.publish("menu:hide");
   // .subscribe(params => this.return = params['return'] || '/forums');
    this.height = window.innerHeight;

  }
}

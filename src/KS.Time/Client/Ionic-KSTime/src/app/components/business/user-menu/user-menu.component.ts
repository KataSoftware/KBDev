import { UserService, BasePage } from 'sfscommon';
import { Component, OnInit, NgModule, Injector } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

import { extend } from 'webdriver-js-extender';
import { MatIconRegistry } from '@angular/material/icon';

@Component({
  selector: 'app-user-menu',
  templateUrl: './user-menu.component.html',
  styleUrls: ['./user-menu.component.scss'],
})

export class UserMenuComponent extends BasePage implements OnInit {

  roleName:string=null;
  userName:string=null;

  constructor(
    public injector: Injector,
    private matIconRegistry: MatIconRegistry,
    private domSanitizer: DomSanitizer, 
    public userService:UserService , 
    

    ) {

      super(injector);
     }

  async ngOnInit() {
    let userData = await this.userService.getUserData();
    this.userName = userData.FirstName;
    
    if (userData.CompanyRoles.length > 0){
      this.roleName = userData.CompanyRoles[0].RoleName;
    }

  }
goMyAccount(){
  this.navCtrl.navigateForward('ubiCustomer/form/mode/my-account');
}
logOff(){
      this.events.publish("user:loggedOut");
}

}

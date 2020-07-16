import { AppSettingsModel } from '../../models/common/models';
import { Component, OnInit, Injector } from '@angular/core';
import { AppFormBasePage } from '../app-form-base/app-form-base.page';
import { StorageService, UserService } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { sfsService } from '../../services/sfs.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.page.html',
  styleUrls: ['./settings.page.scss'],
})
export class SettingsPage extends AppFormBasePage implements OnInit {
  item: AppSettingsModel = null;
  constructor(
    public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
    
    public sfsService: sfsService
  ) {
    super(injector);
    this.title = 'Configuración de la aplicación';


    this.form = new FormGroup({
      Item: new FormGroup({

        SMTPSSLEnabled: new FormControl(null),
        SMTPFromEmail: new FormControl(null),
        SMTPPassword: new FormControl(null),
        SMTPFromName: new FormControl(null),
        SMTPServer: new FormControl(null),
        SMTPPort: new FormControl(null),
        SMTPUser: new FormControl(null),
        AzureBlobStorageConnection: new FormControl(null),
        SaveBlobInAzureStorage: new FormControl(null),
        SaveBlobInDataBase: new FormControl(null),

      })
    });
     this.defaultHref = `configuration`;
    

   }

   async getData() {
    
      let result = await this.sfsService.CustomMethod({  }, "AppSettings", "GetAppSettings");

      if (result.status == "success") {
        this.item = result.data;
        if (this.item != null) {
         
          this.getControl("Item.SMTPSSLEnabled").setValue(this.item.SMTPSSLEnabled);
          this.getControl("Item.SMTPFromEmail").setValue(this.item.SMTPFromEmail);
          this.getControl("Item.SMTPPassword").setValue(this.item.SMTPPassword);
          this.getControl("Item.SMTPFromName").setValue(this.item.SMTPFromName);
          this.getControl("Item.SMTPServer").setValue(this.item.SMTPServer);
          this.getControl("Item.SMTPPort").setValue(this.item.SMTPPort);
          this.getControl("Item.SMTPUser").setValue(this.item.SMTPUser);
          this.getControl("Item.AzureBlobStorageConnection").setValue(this.item.AzureBlobStorageConnection);
          this.getControl("Item.SaveBlobInAzureStorage").setValue(this.item.SaveBlobInAzureStorage);
          this.getControl("Item.SaveBlobInDataBase").setValue(this.item.SaveBlobInDataBase);
          
        }
      }
  
  }

  async ngOnInit() {
    this.getData();
  }

}

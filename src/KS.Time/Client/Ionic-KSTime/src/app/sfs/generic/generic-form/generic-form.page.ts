import { sfsService } from './../../services/sfs.service';
import { Component, OnInit, Injector, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormlyFormOptions, FormlyFieldConfig } from '@ngx-formly/core';
import { ActivatedRoute } from '@angular/router';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { AppFormBasePage } from '../../common/app-form-base/app-form-base.page';
import { BackToListSettings } from '../../models/common/page.model';
import { GenericFormBasePage } from '../../common/app-form-base/generic-form-base.page';
import { GenericModalComponent } from '../generic-modal/generic-modal.component';

@Component({
  selector: 'app-generic-form',
  templateUrl: './generic-form.page.html',
  styleUrls: ['./generic-form.page.scss'],
})
export class GenericFormPage extends GenericFormBasePage implements OnInit {
  constructor(
    public injector: Injector,
    public activatedRoute: ActivatedRoute,
    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService

  ) {

    super(injector, activatedRoute, storage, userService, sfsService);


    if (this.activatedRoute.snapshot.paramMap.get('catalog') != null) {
      this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');
    }



    console.log("route form", this.route, this.route.url);
    this.guidItem = this.route.snapshot.paramMap.get("id");
     if (this.router.url.indexOf("form-tabs") != -1){
       this.isFormTabs=true;
     }
  }
  isFormTabs:boolean=false;
  segment:string="principal";
  async segmentChanged(event:any){
    console.log(event);
  }

  async edit(item:any){
    const modal = await this.modalCtrl.create({
      component: GenericModalComponent,

      componentProps: {
        entityName: this.entityName,
        isFilter: false,
        isModal: true,
        item: item,
        formMode: "edit",
        guidItem: item.Id,
        
      }

    });

    modal.onDidDismiss()
      .then((data: any) => {
        console.log("edit modal data", data);
        if (data != null && data.data != null && data.data.ItemUpdated != null) {
          this.item = data.data.ItemUpdated;
          this.events.publish('item:updated', { itemUpdated: data.data.ItemUpdated, defaultProperty: this.entityModel._DefaultProperty });
          
          //this.ionViewWillEnter();
          
        }
      });
    await modal.present();
  }
}

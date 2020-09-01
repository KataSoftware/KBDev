import { NgModel } from '@angular/forms';
import { Component, OnInit, Injector, Input } from '@angular/core';
import { GenericFormPage } from '../generic-form/generic-form.page';
import { GenericFormBasePage } from '../../common/app-form-base/generic-form-base.page';
import { ActivatedRoute } from '@angular/router';
import { StorageService, UserService } from 'sfscommon';
import { sfsService } from './../../services/sfs.service';

@Component({
  selector: 'app-generic-modal',
  templateUrl: './generic-modal.component.html',
  styleUrls: ['./generic-modal.component.scss']
})
// @Component({
//   selector: 'app-generic-modal',
//   templateUrl: './../generic-form/generic-form.page.html',
//   styleUrls: ['./../generic-form/generic-form.page.scss'],
// })
 export class GenericModalComponent extends GenericFormBasePage  implements OnInit {
  @Input() existentFilter:boolean=false;
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




    this.guidItem = this.route.snapshot.paramMap.get("id");
    




   // this.guidItem = this.route.snapshot.paramMap.get("id");
  }


}

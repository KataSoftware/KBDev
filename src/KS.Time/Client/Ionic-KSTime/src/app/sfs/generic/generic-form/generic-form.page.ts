import { sfsService } from './../../services/sfs.service';
import { Component, OnInit, Injector, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormlyFormOptions, FormlyFieldConfig } from '@ngx-formly/core';
import { ActivatedRoute } from '@angular/router';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { AppFormBasePage } from '../../common/app-form-base/app-form-base.page';
import { BackToListSettings } from '../../models/common/page.model';
import { GenericFormBasePage } from '../../common/app-form-base/generic-form-base.page';

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




    this.guidItem = this.route.snapshot.paramMap.get("id");
  }
}

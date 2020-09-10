import { BrowserModule } from '@angular/platform-browser';
import { Component, OnInit, Input, NgModule, Injector } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PopoverController } from '@ionic/angular/providers/popover-controller';
import { IonicModule } from '@ionic/angular';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../../shared/shared.module';
import { GenericFormBasePage } from '../app-form-base/generic-form-base.page';
import { ActivatedRoute } from '@angular/router';
import { StorageService, UserService, BasePage } from 'sfscommon';
import { sfsService } from '../../services/sfs.service';

@Component({
  selector: 'app-pop-over-menu',
  templateUrl: './pop-over-menu.component.html',
  styleUrls: ['./pop-over-menu.component.scss'],
})
export class PopOverMenuComponent extends BasePage  implements OnInit {

  constructor(
    public injector: Injector
    // public popoverCtrl: PopoverController
    ) { 
    super(injector);



  }
  @Input() options:Array<any>=[];
  async ngOnInit() {}

  async select(item:any) {

    await this.popoverCtrl.dismiss({ selected: item });
  }
}

// @NgModule({
//   declarations: [PopOverMenuComponent],
//   imports: [
//     CommonModule,
//     FormsModule,
//     SharedModule,
  
//     IonicModule,
  
//   ]
// })
// class PopOverMenuModule { }

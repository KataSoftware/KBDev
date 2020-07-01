import { Component, OnInit, Injector } from '@angular/core';
import { AppFormBasePage } from '../app-form-base/app-form-base.page';
import { StorageService, UserService } from 'sfscommon';
import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup, FormControl } from '@angular/forms';
import { secEventLogModel } from 'src/app/models/common/system-models';

@Component({
  selector: 'app-event-log',
  templateUrl: './event-log.page.html',
  styleUrls: ['./event-log.page.scss'],
})
export class EventLogPage extends AppFormBasePage  implements OnInit {

  item:secEventLogModel=null;
  constructor(
    public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService
  ) {
    super(injector);
    this.title = 'Detalle de relación rol y usuario';


    this.form = new FormGroup({
      Item: new FormGroup({

        Title: new FormControl(''),
        IsException: new FormControl(''),  
        Content: new FormControl('')
      })
    });
 
    this.defaultHref = `system/events`;
    this.guidItem = this.route.snapshot.paramMap.get("Id");


  }

  async ngOnInit() {
    this.getData();

  
    
  }
 
  



  
  
  async getData() {
    if (this.guidItem != null) {
      let result = await this.sfsService.GetItem(this.guidItem, secEventLogModel._EntitySetName);
      if (result.status == "success") {
        this.item = result.data;
        if (this.item != null) {
          
          
          this.getControl("Item.Title").setValue(this.item.Title);
          this.getControl("Item.Content").setValue(this.item.Message);
          this.getControl("Item.IsException").setValue(this.item.IsException);
       
        }
      }
    }
  }
  
  
  

}

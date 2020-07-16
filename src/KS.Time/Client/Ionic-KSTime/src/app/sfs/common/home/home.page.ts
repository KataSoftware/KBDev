import { Component, ViewEncapsulation, Injector } from '@angular/core';

import { BasePage } from 'sfscommon';
@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
  encapsulation: ViewEncapsulation.None
})
export class HomePage extends BasePage {

  /**
   *
   */
  constructor(injector: Injector) {
    super(injector);

    this.loggingService.eventLog("");
  }

  public showModal() {
   
    
  }

}

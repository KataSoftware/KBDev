import { Component, OnInit, ViewChild, Injector  } from '@angular/core';
import { BasePage } from 'sfscommon';

@Component({
  selector: 'app-system',
  templateUrl: './system.page.html',
  styleUrls: ['./system.page.scss'],
})
export class SystemPage extends BasePage implements OnInit  {

  constructor(public injector: Injector) {
    super(injector);
  }
  public colsBreak: number;
  ngOnInit() {
   this.colsBreak =  (window.innerWidth <= 400) ? 1 : 2;

  }

  onResize(event) {
    this.colsBreak = (event.target.innerWidth <= 400) ? 1 : 2;
  }

  async goToUsers(){
    this.navCtrl.navigateForward(`system/users`, { animated: true });
  }
}

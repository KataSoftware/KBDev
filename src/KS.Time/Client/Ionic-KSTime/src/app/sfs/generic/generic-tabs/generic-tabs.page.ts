import { PopOverMenuComponent } from './../../common/pop-over-menu/pop-over-menu.component';
import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { BasePage } from 'sfscommon';
import { IonTabs } from '@ionic/angular/directives/navigation/ion-tabs';
import { Subscription } from 'rxjs/internal/Subscription';

@Component({
  selector: 'app-generic-tabs',
  templateUrl: './generic-tabs.page.html',
  styleUrls: ['./generic-tabs.page.scss'],
})
export class GenericTabsPage extends BasePage implements OnInit {

  constructor( injector: Injector ) {
    super(injector);

   }
  listSelected:string="Listas relacionadas";

  tabParams:any=null;
  @ViewChild('tabs', { static: true }) tabs: IonTabs; 
  

  private subs = new Subscription();
  private currentTab: any;
  private tabsDidEnter = false;


  async openMenu(event){
    console.log(event);

    const popover = await this.popoverCtrl.create({
      component: PopOverMenuComponent,
      cssClass: 'my-custom-class',
      event: event,
      translucent: true
    });
    return await popover.present();

  }
  firstLoad:boolean = true; 
  ngOnInit() {
    const tabSub = this.tabs.ionTabsDidChange.subscribe(() => {
      this.currentTab = this.tabs.outlet.component;
      console.log("subscribe", this.currentTab);
    });
    this.subs.add(tabSub);

    //this.tabs.select("principal");

 //   this.tabParams = { entities: ["one", "two"] };

  }

  ionViewWillEnter() {
    console.log("ionViewWillEnter", this);
    if (this.firstLoad == true ){
      this.tabs.select("principal");
    }
    this.firstLoad = false;
    if (this.tabsDidEnter) { // Do not fire on initial load - ionViewWillEnter of child tab will fire
      this.currentTab.tabsWillEnter(); 
    }
  }

  ionViewDidEnter() {
    console.log("ionViewDidEnter", this);
    if (this.tabsDidEnter) { // Do not fire on initial load - ionViewDidEnter of child tab will fire
      this.currentTab.tabsDidEnter(); 
    }
    this.tabsDidEnter = true;
  }

  ionViewWillLeave() {
    this.currentTab.tabsWillLeave();
  }

  ionViewDidLeave() {
    this.currentTab.tabsDidLeave();
  }

  ngOnDestroy() {
    this.subs.unsubscribe();
  }

}

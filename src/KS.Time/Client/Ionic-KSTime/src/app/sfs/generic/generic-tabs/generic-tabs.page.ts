import { sfsService } from './../../services/sfs.service';
import { PopOverMenuComponent } from './../../common/pop-over-menu/pop-over-menu.component';
import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { BasePage } from 'sfscommon';
import { IonTabs } from '@ionic/angular/directives/navigation/ion-tabs';
import { Subscription } from 'rxjs/internal/Subscription';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-generic-tabs',
  templateUrl: './generic-tabs.page.html',
  styleUrls: ['./generic-tabs.page.scss'],
})
export class GenericTabsPage extends BasePage implements OnInit {
  public title:string=null;
  public entityModel: any = null;
  public defaultHref: string;
  public entityName:string;
  constructor( injector: Injector ,
    public activatedRoute: ActivatedRoute,
    public  sfsService: sfsService) {
    super(injector);
    if (this.activatedRoute.snapshot.paramMap.get('catalog') != null) {
      this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');
    }

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
  async ngOnInit() {
    this.defaultHref = 'catalog/' + this.entityName;
    
    //console.log("ngOnInit tabs");
    this.sfsService.SetNavigationData(null, "first-principal-form");

    const tabSub = this.tabs.ionTabsDidChange.subscribe(() => {
      this.currentTab = this.tabs.outlet.component;
      console.log("subscribe", this.currentTab);
    });
    this.subs.add(tabSub);

    
    this.events.subscribe('item:updated', (data) => {
      // user and time are the same arguments passed in `events.publish(user, time)`
      console.log('item:updated', data);
      this.title = data.itemUpdated[data.defaultProperty];
    });
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
    if (this.currentTab != null ){
      this.currentTab.tabsWillLeave();
    }
  }
  async tabsChange1(tabs: IonTabs){
    // ddd
    //if (tabs.getSelected() == "relations"){
    
    this.sfsService.SetNavigationData(tabs.getSelected(), "relations-selected");
    //}

    console.log("ionTabsWillChange", tabs.getSelected());
  }
  async tabsChange2(tabs){
    console.log("ionTabsDidChange", tabs.getSelected());
  }
  ionViewDidLeave() {
    this.currentTab.tabsDidLeave();
  }

  ngOnDestroy() {
    this.subs.unsubscribe();
    this.events.subscribe("first-principal-form");
  }

}

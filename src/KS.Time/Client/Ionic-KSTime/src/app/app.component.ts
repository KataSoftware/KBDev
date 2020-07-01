import { StorageService, UserDataModel } from 'sfscommon';
import { Component, Injector, ElementRef, ViewChild, OnInit, AfterViewInit } from '@angular/core';
import { Platform, MenuController } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';
import { AuthenticationService, EVENT_USER_LOGGED_IN, EVENT_USER_LOGGED_OUT, BasePage, ICompany, SelectCompanyPage, IUserDataModel, LoggingService } from 'sfscommon';
import { Router } from '@angular/router';
import { MainMenuService } from './services/business/main-menu.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html'
})

export class AppComponent extends BasePage implements OnInit, AfterViewInit {

  ngOnInit() {
    this.ionMenu.enable(true, 'first');
  }

  ngAfterViewInit() {

  }
  @ViewChild('menu') menu: ElementRef;

  public appPages = [
    {
      title: 'Inicio',
      url: '/inicio',
      icon: 'menu',
      visible: true,
      active: true
    },
    {
      title: 'Perfil',
      url: '/perfil',
      icon: 'person',
      visible: true,
      active: false
    },
    {
      title: 'Proyectos',
      url: '/KstProject/list',
      icon: 'apps',
      visible: true,
      active: false
    },
    {
      title: 'Actividades',
      url: '/KstActivity/list',
      icon: 'apps',
      visible: true,
      active: false
    },
    
    {
      title: 'Cerrar sesión',
      url: '/logoff',
      icon: 'close',
      visible: true,
      active: false
    },
  ];

  visible = false;
  open = false;
  componentName: any;
  public minimized: boolean = false;
  public disabledMenu: boolean = true;
  public hiddenToolbar: boolean = true;
  public currentUser;
  public rootPage: any = null;
  public IsBrowser: boolean;
  public company: ICompany = null;
  public appLogo: string = 'https://url.blob.core.windows.net/public/scmovil/SC-MOVIL-LOGO.png';

  public currentFirstRole: string;
  public currentFirstRoleKey: string;

  constructor(
    private ionMenu: MenuController,
    public injector: Injector,
    private platform: Platform,
    private splashScreen: SplashScreen,
    private statusBar: StatusBar,
    private storage: StorageService,
    private logging: LoggingService,
    private auth: AuthenticationService, public router: Router, private mainMenuService: MainMenuService) {
    super(injector);
    this.initializeApp();
    this.events.subscribe(EVENT_USER_LOGGED_IN, this.logIn);
    this.events.subscribe(EVENT_USER_LOGGED_OUT, this.logOut);

    this.events.subscribe('company:changed', () => {
      this.checkSelectCompany(this.currentUser);
      this.navCtrl.navigateRoot('reports/list');
    });

  }

  navigateToMenuOption(urlOptionSelected: string) {
    if (urlOptionSelected.endsWith("logoff")) {
      this.logOff();
    } else if (this.systemService.isMobile()) {
      this.navCtrl.navigateRoot(urlOptionSelected);
      this.mainMenuService.toggle();
    }
    else {
      this.navCtrl.navigateRoot(urlOptionSelected);
    }

  }

  public async goToChangeCompany() {
    this.navCtrl.navigateForward('selectcompany');
  }

  public async checkSelectCompany(userData: IUserDataModel) {
    let idCompany = await this.userService.getIdCompanyFromUserData();

    this.logging.eventLog("company id: ", idCompany);
    this.logging.eventLog("Check select company", userData);
    if (idCompany == null && userData.Companies != null && userData.Companies.length > 1) {
      this.logging.eventLog("many companies, companyid:" + this.userService.getIdCompanyFromUserData());
      this.rootPage = SelectCompanyPage;

    } else {
      this.company = await this.userService.getCompanyFromUserData();
      // si hay empresa seleccionada
      this.logging.eventLog("company:", this.company);

      // buscar nombre de la empresa (objeto completo) seleccionada
      if (this.navCtrl) {

        this.rootPage = 'inicio';
      }
    }
  }

  async checkTest() {
    this.storage.get("introShown").then(async result => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
      if (result) {
        this.userService.getUserData()
          .then(result => {
            this.loggingService.eventLog("getUserData", result);
            if (result != null) {
              // se especifica el usuario en la variable local
              this.currentUser = result;
              this.checkSelectCompany(result);
            } else {
              if (this.navCtrl) {
                this.rootPage = 'LoginPage';
              }
            }
          }).catch(error => {
            this.loggingService.eventLogError(error);
          });
      } else {
        // no se ha mostrado el Intro 
        if (this.navCtrl) {
          this.rootPage = 'IntroPage';
        }
      }
    });
  }

  async initializeApp() {
    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
      this.userService.getUserData()
        .then(result => {
          this.loggingService.eventLog("263 getUserData", result);
          if (result != null) {
            // se especifica el usuario en la variable local
            this.currentUser = result;
            this.checkSelectCompany(result);
            this.rootPage = 'CustomLoginPage';
          } else {
            if (this.navCtrl) {
              //this.navCtrl.navigateRoot('/login', { animated: true, animationDirection: 'forward' });
            }
          }
        });
    });

    // Se recuperan las ceredencuales del usuario.
    const userCredentials = await this.userService.getUserData();

    if (userCredentials) {
      this.logIn({ userData: userCredentials });
    }
  }

  logIn = async (loginResponse: { userData: UserDataModel, url?: string }) => {
    console.log("component logIn", loginResponse);
    this.currentUser = loginResponse.userData;
    this.disabledMenu = false;
    this.hiddenToolbar = false;
    this.rolValidate();
    if (loginResponse.url != null) {
      this.navCtrl.navigateRoot(loginResponse.url, { animated: true, animationDirection: 'forward' });
    } else {
      let param = await this.getUserParam("NumAddresses");
      if (param != null && param.Value > 0) {
        // si ya tiene más de 0 direcciones
        if (this.router.url == "/" || this.router.url == "/welcome") {
          this.navCtrl.navigateRoot("dashboard-user", { animated: true, animationDirection: 'forward' });
        }
      }
    }
  }

  logOut = async () => {
    try {
      await this.auth.logout();
      this.currentUser = null;
      this.disabledMenu = true;
      this.hiddenToolbar = true;
      this.navCtrl.navigateRoot('/login?return=' + document.location.hash.replace("#", ""), { animated: true, animationDirection: 'forward' });
      window.location.reload();
    } catch (error) {
      /** this.showAlertMessage('No fue posible cerrar sesión'); */
    }
  }

  routerActive() {

  }

  logOff() {
    this.events.publish("user:loggedOut");
  }

  async rolValidate() {
    let isAdmin = await this.userService.isInRole("admin");
    console.log("isAdmin", isAdmin);
    this.appPages.forEach(page => {
    
      if (page.url == "/KstProject/list" || page.url == "/KstActivity/list" ) {
        page.visible = isAdmin;
      }
    });

    this.appPages = this.appPages.filter(p=> p.visible == true); 
  }

}
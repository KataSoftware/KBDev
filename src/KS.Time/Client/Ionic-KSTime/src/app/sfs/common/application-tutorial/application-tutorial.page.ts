import { Component, Injector, ViewChild } from '@angular/core';
import { IonSlides } from '@ionic/angular';
import { BasePage, UserService, StorageService } from 'sfscommon';

@Component({
  selector: 'app-application-tutorial',
  templateUrl: './application-tutorial.page.html',
  styleUrls: ['./application-tutorial.page.scss'],
})
export class ApplicationTutorialPage extends BasePage {

  @ViewChild(IonSlides) slides: IonSlides;

  isPressed: boolean = false;

  constructor(public injector: Injector) {
    super(injector);
  }

  public goToSlide(slideIndex: number) {
    this.slides.slideTo(slideIndex);
  }

  public async goToHome() {

    try {

      var userData = await this.userService.getUserData();

      this.storageService.set("introShown", true);

      if (userData != null) {
        this.navCtrl.navigateRoot('/');
      } else {
        this.navCtrl.navigateRoot('/login');
      }
    } catch (error) { }
  }

  public pressStart() {

    this.isPressed = !this.isPressed;

    if (this.isPressed == true) {

      setTimeout(() => {
        this.goToHome();
      }, 500);
    }
  }
}

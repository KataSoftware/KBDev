import { MainMenuService } from 'src/app/services/business/main-menu.service';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-main-menu-button',
    templateUrl: './main-menu-button.component.html',
    styleUrls: ['./main-menu-button.component.scss'],
})
export class MainMenuButtonComponent implements OnInit {
    constructor(private mainMenuService: MainMenuService) { }
    ngOnInit(): void {
        this.mainMenuService.visibility(MainMenuService.MENU_VISIBLE);
    }
    toggle() {
        this.mainMenuService.toggle();
    }
}
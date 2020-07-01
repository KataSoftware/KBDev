import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Platform } from '@ionic/angular';


@Injectable({ providedIn: 'root' })
export class MainMenuService {

    public static MENU_VISIBLE = true;
    public static MENU_HIDDEN = false

    private subject = new Subject<boolean>();
    private toggleSubject = new Subject<boolean>();

    private status: boolean = false;

    controller = this.subject.asObservable();
    toggleController = this.toggleSubject.asObservable();

    constructor(private platform: Platform) { }

    changeState(status: boolean) {
        this.subject.next(status);
    }

    toggle() {
        this.toggleSubject.next();
    }

    visibility(status: boolean) {
        this.status = status;
        this.changeState(status);
    }

    getStatus(): boolean {
        return this.status
    }
}
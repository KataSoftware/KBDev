
import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";
import { TimeAgoPipe } from "./timeago";
@NgModule({
    declarations: [TimeAgoPipe],
    imports: [CommonModule],
    exports: [TimeAgoPipe] // <---
})
export class timeagoModule {
}

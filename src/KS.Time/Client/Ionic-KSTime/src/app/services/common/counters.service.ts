import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable()
export class CountersService {
  private _clickCounter = 0;
  private clickCounterObservable: Subject<number> = new Subject();
  public clickCounterObservable$ = this.clickCounterObservable.asObservable();

  get clickCounter(): number {
    return this._clickCounter;
  }

  set clickCounter(value: number) {
    this._clickCounter = value;
  }
  
  public updateClickCounter(): void {
    this.clickCounter += 1;
    this.clickCounterObservable.next(this.clickCounter);
  }
}
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { GenericFormPage } from './generic-form.page';

describe('GenericFormPage', () => {
  let component: GenericFormPage;
  let fixture: ComponentFixture<GenericFormPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GenericFormPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(GenericFormPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

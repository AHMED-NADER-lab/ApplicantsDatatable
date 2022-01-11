import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationAddEditeComponent } from './application-add-edite.component';

describe('ApplicationAddEditeComponent', () => {
  let component: ApplicationAddEditeComponent;
  let fixture: ComponentFixture<ApplicationAddEditeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ApplicationAddEditeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ApplicationAddEditeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

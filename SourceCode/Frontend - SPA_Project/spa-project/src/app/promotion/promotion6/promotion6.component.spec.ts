import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion6Component } from './promotion6.component';

describe('Promotion6Component', () => {
  let component: Promotion6Component;
  let fixture: ComponentFixture<Promotion6Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion6Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion6Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

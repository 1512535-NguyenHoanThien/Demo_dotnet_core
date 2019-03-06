import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion7Component } from './promotion7.component';

describe('Promotion7Component', () => {
  let component: Promotion7Component;
  let fixture: ComponentFixture<Promotion7Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion7Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion7Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

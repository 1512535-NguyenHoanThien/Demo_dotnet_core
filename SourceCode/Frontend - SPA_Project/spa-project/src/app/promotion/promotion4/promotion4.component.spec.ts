import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion4Component } from './promotion4.component';

describe('Promotion4Component', () => {
  let component: Promotion4Component;
  let fixture: ComponentFixture<Promotion4Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion4Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

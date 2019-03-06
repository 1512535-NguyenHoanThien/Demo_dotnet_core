import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion9Component } from './promotion9.component';

describe('Promotion9Component', () => {
  let component: Promotion9Component;
  let fixture: ComponentFixture<Promotion9Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion9Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion9Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

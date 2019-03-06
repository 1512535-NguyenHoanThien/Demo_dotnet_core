import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion8Component } from './promotion8.component';

describe('Promotion8Component', () => {
  let component: Promotion8Component;
  let fixture: ComponentFixture<Promotion8Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion8Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion8Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

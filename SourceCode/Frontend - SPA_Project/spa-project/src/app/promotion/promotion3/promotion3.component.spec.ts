import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion3Component } from './promotion3.component';

describe('Promotion3Component', () => {
  let component: Promotion3Component;
  let fixture: ComponentFixture<Promotion3Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion3Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

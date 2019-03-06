import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Promotion5Component } from './promotion5.component';

describe('Promotion5Component', () => {
  let component: Promotion5Component;
  let fixture: ComponentFixture<Promotion5Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Promotion5Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Promotion5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

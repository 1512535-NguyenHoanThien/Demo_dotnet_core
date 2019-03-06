import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VNPAYComponent } from './vnpay.component';

describe('VNPAYComponent', () => {
  let component: VNPAYComponent;
  let fixture: ComponentFixture<VNPAYComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VNPAYComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VNPAYComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

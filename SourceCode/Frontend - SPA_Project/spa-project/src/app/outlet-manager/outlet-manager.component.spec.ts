import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OutletManagerComponent } from './outlet-manager.component';

describe('OutletManagerComponent', () => {
  let component: OutletManagerComponent;
  let fixture: ComponentFixture<OutletManagerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OutletManagerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OutletManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

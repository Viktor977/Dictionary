import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UkrpageComponent } from './ukrpage.component';

describe('UkrpageComponent', () => {
  let component: UkrpageComponent;
  let fixture: ComponentFixture<UkrpageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UkrpageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UkrpageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

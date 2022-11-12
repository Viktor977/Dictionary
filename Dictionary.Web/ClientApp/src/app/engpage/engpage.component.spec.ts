import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EngpageComponent } from './engpage.component';

describe('EngpageComponent', () => {
  let component: EngpageComponent;
  let fixture: ComponentFixture<EngpageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EngpageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EngpageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

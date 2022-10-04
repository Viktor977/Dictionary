import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  title:string = " Pet project";
  author:string = "Stepanov V.";
  year:string='2022';
  constructor() { }

  ngOnInit() {
  }

}

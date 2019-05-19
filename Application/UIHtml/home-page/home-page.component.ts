import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-page',//html tag ->import.ts
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit { //component name

  constructor() { }

  ngOnInit() {
  }

}

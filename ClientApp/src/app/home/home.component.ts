import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent {

  runLogic(){
    let result = document.getElementById('googleId').attributes;
    console.log('result: ', result);
  }
}

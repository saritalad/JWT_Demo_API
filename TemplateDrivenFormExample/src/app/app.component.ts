import { Component } from '@angular/core';
import { User } from './User';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TemplateDrivenFormExample';
  
  onSubmit(user:any)
  {
console.log(user.value)
  }



}

import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
// This is the method to getvalues passed from Home to Register
  @Input()valuesFromHome: any;
// Adding output properties to get child to parent
@Output() cancelRegister = new EventEmitter();
model: any = {};


  constructor() { }

  ngOnInit() {
  }
register() {
console.log(this.model);

}
cancel() {
  this.cancelRegister.emit(false);

// console.log('Cancelled');
}

}

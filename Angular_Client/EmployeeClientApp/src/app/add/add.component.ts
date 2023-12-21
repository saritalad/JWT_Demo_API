import { Component } from '@angular/core';
import { Employee } from 'src/Models/Employee';
import { EmpService } from '../emp.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent {
  newemp:Employee;
  constructor(private _service:EmpService,private router:Router) { }


  onSubmit(form:any)
  {
    this.newemp=form.value;
   this._service.addEmployee(this.newemp).subscribe();
   this.router.navigate(["/EmpList"]);
  }
}

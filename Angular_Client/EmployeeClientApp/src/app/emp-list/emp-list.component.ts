import { Component } from '@angular/core';
import { EmpService } from '../emp.service';
import { Router } from '@angular/router';
import { Employee } from 'src/Models/Employee';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent {

  emplist:Employee[]=[];
  constructor(private _service:EmpService,private route:Router) {
       
  }
ngOnInit()
{
this._service.getEmployees().subscribe(data=>{this.emplist=data;
  console.log(this.emplist)});



}

Delete(id:number)
{
  this._service.deleteEmployee(id).subscribe();
  window.location.reload();
}

}

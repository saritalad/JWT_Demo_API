import { Component } from '@angular/core';
import { Employee } from '../Models/Employee';
import { ActivatedRoute, Router } from '@angular/router';
import { EmpService } from '../emp.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
currentEmp:Employee;
constructor(private _service:EmpService,private router:Router,private Activeroute:ActivatedRoute) {}

ngOnInit()
{
let Id=this.Activeroute.snapshot.params["id"];
this._service.getEmployeeById(Id).subscribe(data=>{

  this.currentEmp=data;
  console.log(this.currentEmp);
});
}





  
}




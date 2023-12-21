import { Component } from '@angular/core';
import { Employee } from 'src/Models/Employee';
import { EmpService } from '../emp.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
currentemp:Employee;
Id:number
constructor(private _service:EmpService,private activeRoute:ActivatedRoute) {
   
}
ngOnInit()
{
  this.Id=this.activeRoute.snapshot.params["id"];
  this._service.getEmployeeById(this.Id).subscribe(data=>{
this.currentemp=data;
    console.log(this.currentemp);

  })
      

}

}

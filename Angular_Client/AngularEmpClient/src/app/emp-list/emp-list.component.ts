import { Component } from '@angular/core';
import { Employee } from '../Models/Employee';
import { EmpService } from '../emp.service';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent {
emplist:Employee[]=[];
// inject service EmpService to fetch data from HttpClient URL
constructor(private _service:EmpService) {}
 
ngOnInit()
{
this._service.getAllEmployees().subscribe(data=>{this.emplist=data;
console.log(this.emplist)

});

}
  
Delete(id:number)
{
  
this._service.Delete(id).subscribe();
window.location.reload();  
}



}

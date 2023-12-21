import { Component } from '@angular/core';
import { EmpService } from '../emp.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from '../Models/Employee';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent {
  emp:Employee={id:0,name:'',contact:''};

  id:number;
  
    constructor(private _service :EmpService,private route:Router, private activerout:ActivatedRoute) { 
      
      }
  
         ngOnInit(): void {
          this.id= this.activerout.snapshot.params["id"];// route variable 
         // this.id=Number(Id);
           console.log("id ="+this.id)
            this._service.getEmployeeById(this.id).subscribe(data=>{
            this.emp=data;
          
            console.log(this.emp);
                
    });
        }
    onSubmit(emp:any)
    {  
         //  console.log("  "+this.emp);
     this._service.Update(this.emp).subscribe(()=>{console.log(this.emp);});
      
     this.route.navigate(['/EmpList']);
     
    }
}

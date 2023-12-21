import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'
import { Employee } from 'src/Models/Employee';

@Injectable({
  providedIn: 'root'
})
export class EmpService {
url :string="http://localhost:14372/api/Employees"
  constructor(private http:HttpClient) { }

  getEmployees():Observable<any>
  {
   return this.http.get<Employee>(this.url);
  }
// get emplyee by Id
getEmployeeById(id:number):Observable<any>
{

  return this.http.get<Employee>(this.url+"/"+id);
}

addEmployee(emp:Employee):Observable<any>
{

  return this.http.post(this.url,emp);
}


// delete service 
deleteEmployee(id:number):Observable<any>{

  return this.http.delete<any>(this.url + "/" + id)

 }

}

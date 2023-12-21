import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http'
import { Employee } from './Models/Employee';
import { Observable } from 'rxjs/internal/Observable';
import { catchError, throwError } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class EmpService {
url:string="http://localhost:14372/api/Emp";
url1:string="http://localhost:14372/Emp/GetAllEmployees"
httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };

  constructor(private http:HttpClient) { }

getAllEmployees():Observable<any>
{
  return this.http.get<Employee>(this.url1);
}
// write a method to call Post method
AddEmployee(newemp:Employee):Observable<any>
{

  return this.http.post(this.url,newemp);
}
// search record by Id  GetEmployeeById method 
getEmployeeById(id:number):Observable<any>
{
 return this.http.get<Employee>(this.url+"/"+id)
}

Update(emp:Employee):Observable<any>
{
  return this.http.put<Employee>(this.url+"/"+emp.id,emp,this.httpOptions).pipe(catchError(this.handleError));

}
handleError(error:HttpErrorResponse){
  let errorMessage="";
  errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
  alert(errorMessage);
  return throwError(errorMessage);
}
Delete(id:number):Observable<any>
{

return this.http.delete(this.url+"/"+id);
}


}

import { TestBed } from '@angular/core/testing';
import {HttpClientTestingModule, HttpTestingController} from '@angular/common/http/testing'
import { EmpService } from './emp.service';
import { HttpClient } from '@angular/common/http';


describe('EmpService', () => {
    let service: EmpService;
    let http:HttpClient;
    let httptestingcontroller:HttpTestingController
  beforeEach(() => {
    TestBed.configureTestingModule({
imports:[HttpClientTestingModule],
providers:[EmpService]
    });
    
    service = TestBed.inject(EmpService);
    http=TestBed.inject(HttpClient);
    httptestingcontroller=TestBed.inject(HttpTestingController)
  });

  it('should be created', () => {
    expect(service).toBeDefined();
  });
});

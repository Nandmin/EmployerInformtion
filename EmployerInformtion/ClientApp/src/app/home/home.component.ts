import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { emloyeeInformation } from '../models/employeeInformation';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {
  employeeInformation: Array<emloyeeInformation> = [];

  constructor (
    private httpClient : HttpClient
  ){

  }

  ngOnInit() {
    this.httpClient.get('http://localhost:44301/api/EmployeeInfo').subscribe(response: Array<emloyeeInformation>) => {
      this.employeeInformation = response;
    };
  }
}

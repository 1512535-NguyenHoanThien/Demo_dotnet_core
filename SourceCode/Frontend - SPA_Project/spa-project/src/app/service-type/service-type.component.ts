import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-service-type',
  templateUrl: './service-type.component.html',
  styleUrls: ['./service-type.component.scss']
})
export class ServiceTypeComponent implements OnInit {


  listServices: any;

  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  ngOnInit() {
	  this.http.get('http://localhost:5000/api/services/list').subscribe(
	      data => {
	        this.listServices = data;
	      })
  }

  onSelected(listServices){
    this.router.navigate(['/services',listServices.id]);
  }

}

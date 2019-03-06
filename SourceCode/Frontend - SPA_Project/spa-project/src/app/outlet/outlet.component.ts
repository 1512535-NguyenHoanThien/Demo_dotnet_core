import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-outlet',
  templateUrl: './outlet.component.html',
  styleUrls: ['./outlet.component.scss']
})
export class OutletComponent implements OnInit {

  httpOptions = {
    headers: new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    })
  };

  listOutlet: any;
  outletPicked: any = 1;

  lat: Number;
  lng: Number;
  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  ngOnInit() {

    this.http.get('http://localhost:5000/api/outlets/list').subscribe(
      data => {
        this.listOutlet = data;
        this.lat = data[0]['latitude'];
        this.lng = data[0]['longitude'];
      });
  }

  onSubmit(f: NgForm) {
    return this.http.put<void>("http://localhost:5000/api/outlets/update",
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => alert("Chỉnh sửa outlet thành công."));
  }

  // showMap(itemId) {
  //   this.http.get(`http://localhost:5000/api/outlets/picked?id=${itemId}`).subscribe(
  //     data => {
  //       this.outletPicked = data;
  //       this.lat = data['latitude'];
  //       this.lng = data['longitude'];
  //     }
  //   );
  // }

}

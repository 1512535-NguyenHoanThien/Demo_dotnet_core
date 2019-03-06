import { Component, OnInit } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Marker } from '../model/marker';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
declare var google: any;
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})



export class HomeComponent implements OnInit {

  listOutlet: any;
  outletPicked: any = 1;

  lat: Number;
  lng: Number;
  outeltMarkers: Marker[] = [];
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
        this.listOutlet.forEach(element => {
          const marker = new Marker();
          marker.latitude = element.latitude;
          marker.longitude = element.longitude;
          marker.info = element.name;
          this.outeltMarkers.push(marker);
        });
        console.log(this.outeltMarkers.length);
      });
  }

  showMap(itemId) {
    this.http.get(`http://localhost:5000/api/outlets/picked?id=${itemId}`).subscribe(
      data => {
        this.outletPicked = data;
        this.lat = data['latitude'];
        this.lng = data['longitude'];
      }
    );
  }
}

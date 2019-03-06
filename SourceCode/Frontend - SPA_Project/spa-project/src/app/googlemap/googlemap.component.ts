import { Component, OnInit, Input } from '@angular/core';
import { Marker } from '../model/marker';
import { HttpClient } from '@angular/common/http';
declare var google: any;
@Component({
  selector: 'app-googlemap',
  templateUrl: './googlemap.component.html',
  styleUrls: ['./googlemap.component.scss']
})
export class GooglemapComponent implements OnInit {
  // tslint:disable-next-line:no-input-rename
  @Input('isRoute') isRoute: boolean;
  // tslint:disable-next-line:no-input-rename
  @Input('outletLat') outletLat: Number;
  // tslint:disable-next-line:no-input-rename
  @Input('outletLng') outletLng: Number;
  // tslint:disable-next-line:no-input-rename
  @Input('outletName') outletName: string;
  map: undefined;
  zoom: 20;
  directionsService = new google.maps.DirectionsService();
  directionsDisplay = new google.maps.DirectionsRenderer({ suppressMarkers: true });

  latcenter = 10.8238784;
  lngcenter = 106.69051739999999;
  myLat: any;
  myLng: any;
  listOutlet: any;
  constructor(
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.initMap();
    console.log(this.outletLat);
    console.log(this.outletLng);
  }
  initMap() {
    this.map = new google.maps.Map(document.getElementById('map'), {
      zoom: 15,
      center: { lat: Number(this.latcenter), lng: Number(this.lngcenter) },
      scrollwheel: true,
      zoomControl: true
    });
    this.directionsDisplay.setMap(this.map);
    if (this.isRoute === false) {
      this.drawMarkers();
    } else {
      this.getYourPostion();
    }

  }

  drawMarkers() {
    this.http.get('http://localhost:5000/api/outlets/list').subscribe(
      data => {
        this.listOutlet = data;
        this.listOutlet.forEach(element => {
          const marker = new google.maps.Marker({
            position: { lat: Number(element.latitude), lng: Number(element.longitude) },
            map: this.map,
            title: element.name
          });
          const infowindow = new google.maps.InfoWindow({
            content: `<p>${element.name}</p>`
          });
          infowindow.open(this.map, marker);
        });
      });
  }
  getYourPostion() {
    if (navigator.geolocation) {
      navigator.geolocation.getCurrentPosition(
        position => {
          this.myLat = Number(position.coords.latitude);
          this.myLng = Number(position.coords.longitude);
          // const marker = new google.maps.Marker({
          //   position: { lat: this.myLat, lng: this.myLng }
          // });
          // marker.setAnimation(google.maps.Animation.BOUNCE);
          // marker.setMap(this.map);
          this.calculateAndDisplayRoute(this.directionsService, this.directionsDisplay);
        },
        error => {
          console.log('Error code: ' + error.code + '<br /> Error message: ' + error.message);
        }
      );

    }

  }

  calculateAndDisplayRoute(directionsService, directionsDisplay) {

    const originMarker = new google.maps.Marker({
      position: { lat: Number(this.myLat), lng: Number(this.myLng) },
      map: this.map,
    });

    originMarker.setAnimation(google.maps.Animation.BOUNCE);
    const destinationMarker = new google.maps.Marker({
      position: { lat: Number(this.outletLat), lng: Number(this.outletLng) },
      map: this.map,
    });
    const destinationMarkerInfowindow = new google.maps.InfoWindow({
      content: `<p>${this.outletName}</p>`
    });
    destinationMarkerInfowindow.open(this.map, destinationMarker);
    directionsService.route({
      origin: { lat: Number(this.myLat), lng: Number(this.myLng) },
      destination: { lat: Number(this.outletLat), lng: Number(this.outletLng) },
      optimizeWaypoints: true,
      travelMode: 'DRIVING'
    }, function (response, status) {
      if (status === 'OK') {
        directionsDisplay.setDirections(response);
        const route = response.routes[0];
      } else {
        // window.alert('Directions request failed due to ' + status);
      }
    });
  }
}

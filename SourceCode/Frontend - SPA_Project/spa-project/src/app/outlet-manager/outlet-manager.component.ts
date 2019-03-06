import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { OutletFull } from 'src/app/model/outlet';
import { ServiceFull } from 'src/app/model/service';

@Component({
  selector: 'app-outlet-manager',
  templateUrl: './outlet-manager.component.html',
  styleUrls: ['./outlet-manager.component.scss']
})
export class OutletManagerComponent implements OnInit {

  httpOptions = {
    headers: new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    })
  };

  listOutlet: any;
  listService: any;
  outlet: OutletFull;
  serviceFull: ServiceFull;

  selectedServiceTypeId: number;
  selectedOutletStatus: number;

  outletName: string;
  outletAddress:string;
  outletPhone: string;

  lat: Number;
  lng: Number;
  displayCreateDialog:boolean;
  displayCreateOutletDialog: boolean;
  displayCreateServiceDialog: boolean;

  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  ngOnInit() {

    this.http.get('http://localhost:5000/api/outlets/list').subscribe(
      data => {
        console.log(data)
        this.listOutlet = data;
      })

    this.http.get('http://localhost:5000/api/services/list').subscribe(
      data => {
        console.log(data)
        this.listService = data;
      })

    this.serviceFull = {
      id: 0,
      serviceName: '',
      price: 0,
      content: '',
      time: 0,
      imgUrl: '',
      serviceTypeId: 0
    };

    this.outlet = {
      id: 0,
      name: '',
      address: '',
      phone: '',
      status: true,
      latitude: 0,
      longitude: 0
    };

    this.displayCreateDialog = false;
    this.displayCreateOutletDialog = false;
    this.displayCreateServiceDialog = false;
  }

  showAddOutletDialog() {
    this.displayCreateDialog = true;
    this.displayCreateOutletDialog = true;
    this.displayCreateServiceDialog = false;
  }

  showAddServiceDialog() {
    this.displayCreateDialog = true;
    this.displayCreateOutletDialog = false;
    this.displayCreateServiceDialog = true;
  }

  UpdateOutlet(f: NgForm) {

    return this.http.put<void>("http://localhost:5000/api/outlets/update",
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => {
        alert("Chỉnh sửa outlet thành công.");
        window.location.reload()
      });
  }

  UpdateService(f: NgForm) {

    return this.http.put<void>("http://localhost:5000/api/services/update",
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => {
        alert("Chỉnh sửa service thành công.");
        window.location.reload()
      });
  }

  createOutlet() {
    if (this.selectedOutletStatus == 1)
      this.outlet.status = true;
    else
      this.outlet.status = false;

    this.outlet.name = this.outletName;
    this.outlet.address = this.outletAddress;
    this.outlet.phone = this.outletPhone;
      console.log(this.outlet)

    return this.http.post("http://localhost:5000/api/outlets/open",
      this.outlet, this.httpOptions).subscribe(() => {
        alert("Thêm outlet thành công.");
        window.location.reload();
        this.displayCreateDialog = false;
        this.displayCreateOutletDialog = false;
      });
  }

  createService() {
    this.serviceFull.serviceTypeId = this.selectedServiceTypeId;
    return this.http.post("http://localhost:5000/api/services/open",
      this.serviceFull, this.httpOptions).subscribe(() => {
        alert("Thêm service thành công.");
        window.location.reload();
        this.displayCreateDialog = false;
        this.displayCreateServiceDialog = false;
      });
  }

}

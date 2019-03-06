import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { AuthService } from '../authenticate/auth.service';
import { ItemServices } from './itemService';
import { Booking } from '../model/booking';
// import { empty } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss']
})

export class BookComponent implements OnInit {
  header: HttpHeaders = new HttpHeaders({ 'Accept': 'application/json', 'Content-Type': 'application/json' });
  data: any;
  isLogin = false;
  tokenInfo: any;
  FullName: any;
  PhoneNumber: any;
  listservices: ItemServices[] = [];
  carts = [];
  outlets: any;
  outletSelected: any = 1;


  therapits: any;
  therapitSelected: any = 1;
  bookingModel: Booking = new Booking();

  constructor(
    private http: HttpClient,
    private router: Router,
    private authService: AuthService
  ) { }

  ngOnInit() {
    this.isLogin = this.authService.isToken();
    if (this.isLogin === false) {
      this.router.navigate(['/login']);
    } else {
      this.tokenInfo = this.authService.getDecodedAccessToken();
      this.FullName = this.tokenInfo.FullName;
      this.PhoneNumber = this.tokenInfo.PhoneNumber;

      this.http.get('http://localhost:5000/api/services/list').subscribe(
        data => {
          this.data = data;
          this.listservices = this.data;
          this.listservices.forEach(element => {
            element.quantity = 0;
          });
          console.log(this.listservices);
        }
      );

      this.http.get('http://localhost:5000/api/outlets/select').subscribe(
        data => {
          this.outlets = data;
          this.bookingModel.OutletId = this.outlets[0].id;
        }
      );

      this.http.get('http://localhost:5000/api/account/therapit').subscribe(
        data => {
          this.therapits = data;
          this.bookingModel.Therapit = this.therapits[0].id;
        }
      );
      this.tokenInfo = this.authService.getDecodedAccessToken();
      this.bookingModel.UserId = this.tokenInfo.Id;

    }
  }

  addCart(item) {
    item.quantity = item.quantity + 1;
    this.bookingModel.TotalPrice = this.bookingModel.TotalPrice + item.price;
    this.bookingModel.TotalTime = this.bookingModel.TotalTime + item.time;
  }

  removeCart(item) {
    if (item.quantity === 0) {
      return;
    }
    item.quantity = item.quantity - 1;
    this.bookingModel.TotalPrice = this.bookingModel.TotalPrice - item.price;
    this.bookingModel.TotalTime = this.bookingModel.TotalTime - item.time;
  }
  setOutlet(item) {
    this.bookingModel.OutletId = item;
  }
  setTherapit(item) {
    this.bookingModel.Therapit = item;
  }
  booking() {
    this.listservices.forEach(element => {
      if (element.quantity > 0) {
        for (let index = 0; index < element.quantity; index++) {
          this.bookingModel.Services.push(element.id);
        }
      }
    });
    // this.bookingModel.DateTimeBooked.toString();
    console.log(this.bookingModel);
    if (this.bookingModel.TotalPrice > 1000) {
      if (confirm(`Vì hóa đơn bạn trên 1 triệu, Vui lòng nhấp OK để thanh toán`) === true) {
        localStorage.setItem('booking', JSON.stringify(this.bookingModel));
        window.location.href =
          `https://obscure-wave-10433.herokuapp.com/order/create_payment_url?amount=${(this.bookingModel.TotalPrice * 1000)}`;
        return;
      }
    } else {
      this.http.post(`http://localhost:5000/api/appointment/booking`, this.bookingModel, { headers: this.header }).subscribe(
        data => {
          alert('Bạn đã đặt lịch thành công');
          window.location.reload();
        }
      );
    }
  }

}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-vnpay',
  templateUrl: './vnpay.component.html',
  styleUrls: ['./vnpay.component.scss']
})
export class VNPAYComponent implements OnInit {
  responseCode: any;
  bookingModel: any;
  header: HttpHeaders = new HttpHeaders({ 'Accept': 'application/json', 'Content-Type': 'application/json' });
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.responseCode = this.route.snapshot.queryParamMap.get('vnp_ResponseCode');
    if (this.responseCode === '00') {
      this.bookingModel = JSON.parse(localStorage.getItem('booking'));
      this.http.post(`http://localhost:5000/api/appointment/booking`, this.bookingModel, { headers: this.header }).subscribe(
        data => {
          localStorage.removeItem('booking');
          alert('Bạn đã đặt lịch thành công');
          window.location.replace('./book');
        }
      );
    }
  }

}

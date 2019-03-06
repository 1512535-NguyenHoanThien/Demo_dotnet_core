import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { History } from '../model/history';
@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.scss']
})
export class HistoryComponent implements OnInit {
  userId = '';
  data: any;
  histories: any;
  details: any;
  headers = new HttpHeaders({
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  });

  constructor(
    private http: HttpClient,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.userId = this.route.snapshot.queryParamMap.get('userId');
    this.getHistory();
  }

  getHistory() {
    this.http.get(`http://localhost:5000/api/appointment/history?userId=${this.userId}`, { headers: this.headers }).subscribe(
      data => {
        this.histories = data;
        console.log(this.histories);
      }
    );
  }
  getDetail(item) {
    item.isShow = true;
    this.http.get(`http://localhost:5000/api/appointment/detail?appointmentId=${item.id}`, { headers: this.headers }).subscribe(
      data => {
        this.details = data;
        console.log(this.details);
      }
    );
  }

}

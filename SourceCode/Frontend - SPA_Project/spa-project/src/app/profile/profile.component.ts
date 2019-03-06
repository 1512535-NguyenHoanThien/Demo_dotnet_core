import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { AuthService } from '../authenticate/auth.service';
import { NgForm } from '@angular/forms';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {

  url = 'http://localhost:5000/api';
  isLogin = false;
  profileInfomation: any;
  PhoneNumber: any;
  tokenInfo: any;

  httpOptions = {
    headers: new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    })
  };

  user: any;
  Id = '';
  FullName = '';
  Profession = '';
  Address = '';
  DateOfBirth = '';
  Gender = '';
  IdentifyCard = '';
  Role = '';
  Email = '';
  Password = '';

  constructor(
    private http: HttpClient,
    private authService: AuthService,
    private router: Router,
    private datePipe: DatePipe
  ) { }

  ngOnInit() {
    this.isLogin = this.authService.isToken();

    if (this.isLogin === false) {
      this.router.navigate(['/login']);
      alert("Bạn chưa đăng nhập.")
    } else {
      this.tokenInfo = this.authService.getDecodedAccessToken();
      this.PhoneNumber = this.tokenInfo.PhoneNumber;
      this.Id = this.tokenInfo.Id;

      this.http.get(`http://localhost:5000/api/account/picked?phoneNumber=${this.PhoneNumber}`).subscribe(
        data => {
          this.PhoneNumber = data['phoneNumber'];
          this.Email = data['email']
          this.FullName = data['fullName'];
          this.Password = data['password'];
          this.Profession = data['profession'];
          this.Address = data['address'];
          this.DateOfBirth = this.datePipe.transform(new Date(data['dateOfBirth']), 'yyyy-MM-dd');
          if (data['gender']) {
            this.Gender = 'Nữ';
          }
          else
            this.Gender = 'Nam';
          this.IdentifyCard = data['identifyCard'];
          this.Role = this.tokenInfo.Role;
        }
      );
    }
  }

  UpdateProfile(f: NgForm) {
    if (f.value.gender == 'Nam' || f.value.gender == 'nam')
      f.value.gender = 0;
    else if (f.value.gender == 'Nữ' || f.value.gender == 'Nư' || f.value.gender == 'Nu' || f.value.gender == 'nu' || f.value.gender == 'nư' || f.value.gender == 'nữ')
      f.value.gender = 1;
    else {
      alert("Bạn nhập sai cấu trúc giới tính.");
      return;
    }
    f.value.DateOfBirth += 'T00:00:00'
    console.log(f.value.DateOfBirth);
    return this.http.put<void>("http://localhost:5000/api/account/update",
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => { alert("Chỉnh sửa thông tin thành công."); window.location.reload(); });
  }

  ChangePassword(f: NgForm) {
    if (f.value.confirm != f.value.newPass)
      return alert("Mật khẩu mới không khớp. Vui lòng nhập lại.");
    this.http.post<void>(`http://localhost:5000/api/account/changepass?phoneNumber=${this.PhoneNumber}`,
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => {});
    this.http.post<void>(`http://localhost:5000/api/account/changepass?phoneNumber=${this.PhoneNumber}`,
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => {});
    return this.http.post<void>(`http://localhost:5000/api/account/changepass?phoneNumber=${this.PhoneNumber}`,
      JSON.stringify(f.value),
      this.httpOptions).subscribe(() => { alert("Chỉnh sửa thông tin thành công."); window.location.reload(); });
  }
}

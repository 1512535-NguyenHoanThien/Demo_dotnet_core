import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../auth.service';

import { Outlet } from 'src/app/model/outlet';
import { RegisterUser, ViewUser } from 'src/app/model/user';

@Component({
  selector: 'app-user-management',
  templateUrl: './user-management.component.html',
  styleUrls: ['./user-management.component.scss']
})
export class UserManagementComponent implements OnInit {

  // Define binding data
  data: any;
  cols: any[];
  users: RegisterUser[];
  outlets: Outlet[];
  user: RegisterUser;
  userView: ViewUser;
  // Define model event
  selectedValue: string;
  selectedOutlet: Outlet;
  selectedUser: RegisterUser;
  newUser: boolean;
  displayCreateDialog: boolean;
  displayViewDialog: boolean;
  editView: boolean;
  genders = [];

  constructor(
    private router: Router,
    private http: HttpClient,
    private authService: AuthService
  ) { }

  ngOnInit() {
    this.editView = false;
    this.getAllUser();
    this.getAllOutlet();
    this.cols = [
      { field: 'fullName', header: 'Họ Tên' },
      { field: 'email', header: 'Email' },
      { field: 'phoneNumber', header: 'Số điện thoại' },
      { field: 'role', header: 'Chức vụ' }
    ];
    this.genders = [
      { label: 'Nam', value: 'MALE'},
      { label: 'Nữ', value: 'FEMALE'},
    ];
  }

  getAllUser() {
    this.http.get('http://localhost:5000/api/account/all').subscribe(
      data => {
        this.data = data;
        this.users = this.data;
      });
  }
  showDialogToAdd() {
    this.newUser = true;
    this.user = { id: '', email: '', fullname: '', phoneNumber: '', role: '' };
    this.displayCreateDialog = true;
  }

  create() {
    this.user.role = this.selectedValue;
    this.http.post('http://localhost:5000/api/account/createUser', this.user, { headers: this.authService.header }).subscribe(
      data => {
        this.getAllUser();
      }
    );
    this.displayCreateDialog = false;
  }
  getAllOutlet() {
    this.http.get('http://localhost:5000/api/outlets/select').subscribe(
      data => {
        this.data = data;
        this.outlets = this.data;
      }
    );
  }
  onRowSelect(event) {
    this.newUser = false;
    this.displayViewDialog = true;
    this.http.get(`http://localhost:5000/api/account?id=${event.data.id}`).subscribe(
      data => {
        this.data = data;
        this.userView = this.data;
        if (this.userView.gender === 'MALE') {
          this.userView.gender = 'Nam';
        } else {
          this.userView.gender = 'Nữ';
        }
        console.log(this.userView);
      }
    );
  }
  setEdit() {
    this.editView = true;
  }
  resetEditStatus() {
    this.editView = false;
  }
  save() {
    console.log(this.userView.dateOfBirth);
  }


}

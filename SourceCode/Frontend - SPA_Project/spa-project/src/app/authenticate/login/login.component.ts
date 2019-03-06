import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  isLogin = false;
  registerForm: FormGroup;
  submitted = false;
  tokenInfo;
  expireDate;
  public model = {
    password: '',
    phoneNumber: '',
    rememberMe: false
  };
  header: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });
  constructor(
    private router: Router,
    private formBuilder: FormBuilder,
    private http: HttpClient,
    private authService: AuthService
  ) { }

  ngOnInit() {
    this.isLogin = this.authService.isToken();
    if (this.isLogin === true) {
      this.router.navigate(['./home']);
    } else {
      this.registerForm = this.formBuilder.group({
        phone: ['', [Validators.required, Validators.minLength(10)]],
        password: ['', [Validators.required, Validators.minLength(6)]],
        rememberMe: ['']
      });
    }
  }
  get f() { return this.registerForm.controls; }
  onSubmit() {
    this.submitted = true;
    // stop here if form is invalid
    if (this.registerForm.invalid) {
      return;
    } else {
      console.log(this.model);
      this.http.post('http://localhost:5000/api/account/login', this.model, { headers: this.header }).subscribe(
        data => {
          this.authService.storageToken(data);
          this.router.navigate(['./home']);
        }
        , error => {
          alert('Sai tài khoản hoặc mật khẩu.');
        }
      );
    }
  }
}

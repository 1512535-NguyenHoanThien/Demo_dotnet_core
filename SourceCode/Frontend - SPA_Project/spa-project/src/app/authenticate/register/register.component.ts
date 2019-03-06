import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  submitted = false;
  public model = {
    email: '',
    password: '',
    phoneNumber: '',
    fullName: '',
    role: ''
  };
  header: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });

  constructor(
    private router: Router,
    private formBuilder: FormBuilder,
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      phone: ['', [Validators.required, Validators.minLength(10)]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      fullName: ['', [Validators.required]]
    });
  }
  get f() { return this.registerForm.controls; }
  onSubmit() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.registerForm.invalid) {
      return;
    } else {
      this.model.role = 'CUSTOMER';
      this.http.post('http://localhost:5000/api/account/register', this.model, { headers: this.header }).subscribe(
        () => { alert("Chào mừng bạn đến với H&B Spa."); this.router.navigate(['./login']); }
      );
    }
  }

}

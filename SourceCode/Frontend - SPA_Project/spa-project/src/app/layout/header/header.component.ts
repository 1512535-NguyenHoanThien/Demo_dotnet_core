import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/authenticate/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  isLogin = false;
  tokenInfo: any;
  FullName: any;
  isAdmin: any;

  constructor(
    private authService: AuthService,
    private router: Router
  ) { }

  ngOnInit() {
    this.isLogin = this.authService.isToken();
    if (this.isLogin === false) {

    } else {
      this.tokenInfo = this.authService.getDecodedAccessToken();
      console.log(this.tokenInfo);
      this.FullName = this.tokenInfo.FullName;
      this.isAdmin = this.tokenInfo.Role;
    }
  }
  logOut() {
    this.authService.removeToken();
    window.location.reload();
  }
}

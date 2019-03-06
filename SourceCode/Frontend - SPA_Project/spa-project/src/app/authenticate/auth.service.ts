import { Injectable } from '@angular/core';
import * as jwt_decode from 'jwt-decode';
import { HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  tokenKey = 'tokenKey';
  token: any;
  header: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });
  constructor() { }

  storageToken(token: any) {
    localStorage.setItem(this.tokenKey, token);
  }
  removeToken() {
    localStorage.removeItem(this.tokenKey);
  }
  isToken(): any {
    if (localStorage.getItem(this.tokenKey) == null) {
      return false;
    } else { return true; }
  }
  getDecodedAccessToken(): any {
    this.token = localStorage.getItem(this.tokenKey);
    try {
      return jwt_decode(this.token);
    } catch (Error) {
      return null;
    }
  }
  isTokenExpired(token) {
    return true;
  }
  getHeader() {
    return this.header;
  }

}

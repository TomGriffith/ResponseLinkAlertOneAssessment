import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiPaths, environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root',
})
export class LoginService {

  constructor(private http: HttpClient) {

  }

  getToken() {
    return this.http.get(environment.apiUrl + ApiPaths.Jwt);
  }
}

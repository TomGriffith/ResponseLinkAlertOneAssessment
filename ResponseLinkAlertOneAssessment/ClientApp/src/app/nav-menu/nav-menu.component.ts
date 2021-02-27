import { Component } from '@angular/core';
import { LoginService } from '../core/services/login.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  validJwt = false;

  constructor(private loginService: LoginService) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  checkLoginStatus() {
    const token = localStorage.getItem('jwt');
    if (token) {
      return true;
    } else {
      return false;
    }
  }

  logIn_Click() {
    // clear old token then retrieve and store new one
    localStorage.removeItem('jwt');
    this.loginService.getToken()
      .subscribe(response => {
        const token = Object.values(response)[0];
        localStorage.setItem('jwt', token);
      });
  }

  logOut_Click() {
    localStorage.removeItem('jwt');
  }
}

import { Injectable } from '@angular/core';

@Injectable()
export class CustomerService {
  constructor() {

  }
}

export class Customer {
  firstName: string;
  lastName: string;

  constructor() {
    this.firstName = '';
    this.lastName = '';
  }
}


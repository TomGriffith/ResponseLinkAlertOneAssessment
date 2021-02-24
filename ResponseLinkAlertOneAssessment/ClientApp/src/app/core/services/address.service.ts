import { Injectable } from '@angular/core';

@Injectable()
export class AddressService {
    constructor() {

    }
}

export class Address {
  addr1: string;
  addr2: string;
  city: string;
  state: string;
  zip: string;
  zipExt: string;

  constructor() {
    this.addr1 = '';
    this.addr2 = '';
    this.city = '';
    this.state = '';
    this.zip = '';
    this.zipExt = '';
  }
}


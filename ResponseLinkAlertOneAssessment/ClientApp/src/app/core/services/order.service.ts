import { Injectable } from '@angular/core';
import { Address } from './address.service';
import { Customer } from './customer.service';
import { IItem, ItemService } from './item.service';
import { IShippingOption } from './shipping-option.service';

@Injectable()
export class OrderService {
  constructor() {

  }
}

export class Order {
  customer: Customer;
  billingAddress: Address;
  shippingAddress: Address;
  shippingSameAsBilling: boolean;
  items: IItem[];
  chosenShipping: IShippingOption;

  constructor() {
    this.customer = new Customer();
    this.billingAddress = new Address();
    this.shippingAddress = new Address();
  }
}



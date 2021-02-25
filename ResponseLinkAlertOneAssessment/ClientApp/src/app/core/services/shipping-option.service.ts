import { Injectable } from '@angular/core';
import { IShippingOption } from '../models/iShippingOption.model';

@Injectable()
export class ShippingOptionService {
  constructor() {

  }

  // this would normally pull from a database
  // but hard coded for this example
  static getShippingOptions() {
    return [
      { cost: 0.00, id: "1", description: "1 to 2 Weeks" },
      { cost: 5.99, id: "2", description: "Two Day" },
      { cost: 9.99, id: "3", description: "Next Day" }
    ] as IShippingOption[];
  }

  // this would normally select from a database but
  // I use .find to get it from the hard coded
  // examples instead
  static getShippingOption(id: string) {
    return this.getShippingOptions()
      .find(s => s.id === id);
  }
}


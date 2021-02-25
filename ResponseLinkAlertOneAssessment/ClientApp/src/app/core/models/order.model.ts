import { Address } from "./address.model";
import { Customer } from "./customer.model";
import { IItem } from "./iItem.model";
import { IShippingOption } from "./iShippingOption.model";

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

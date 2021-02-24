import { Component } from '@angular/core';
import { AddressComponent } from '../address/address.component';
import { Address } from '../core/services/address.service';
import { Customer } from '../core/services/customer.service';
import { ItemService } from '../core/services/item.service';
import { Order } from '../core/services/order.service';
import { ShippingOptionService } from '../core/services/shipping-option.service';

@Component({
    selector: 'app-order',
    templateUrl: './order.component.html',
    styleUrls: ['./order.component.css']
})
/** order component*/
export class OrderComponent {
  order = {} as Order;
  shippingOptions = ShippingOptionService.getShippingOptions();

    /** order ctor */
  constructor() {
      this.order.items = ItemService.getItems();
      this.order.customer = new Customer();
      this.order.billingAddress = new Address();
      this.order.shippingAddress = new Address();
  }

  public removeItem_click(e: Event) {
    // get the asssociated item ID stored in the link's attributes
    let link = e.target as HTMLInputElement;
    let itemId = link.getAttribute('data-item-id');
    // filter the items removing the item with matching ID
    this.order.items = this.order.items.filter(i => i.id.toString() !== itemId);
  }

  public shippingOption_change(e: Event) {
    const selected = e.target as HTMLElement;
    const selectedId = selected.id;
    this.order.chosenShipping = ShippingOptionService.getShippingOption(selectedId);
  }

  public getTotalCost() {
    let totalCost = 0.00;
    this.order.items.forEach(i => {
      totalCost += i.cost * i.quantity;
    });
    if (this.order.chosenShipping) {
      totalCost += this.order.chosenShipping.cost;
    }
    return totalCost;
  }

  public submitOrder_click() {
    // todo - submit the order to the API and save to database
  }
}

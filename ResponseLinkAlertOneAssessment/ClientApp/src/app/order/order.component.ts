import { Component } from '@angular/core';
import { Address } from '../core/models/address.model';
import { Customer } from '../core/models/customer.model';
import { Order } from '../core/models/order.model';
import { ItemService } from '../core/services/item.service';
import { OrderService } from '../core/services/order.service';
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
  constructor(private orderService: OrderService) {
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
    // creat shippng option object based on selection and
    // add to the order object to update the form
    const selected = e.target as HTMLElement;
    const selectedId = selected.id;
    this.order.chosenShipping = ShippingOptionService.getShippingOption(selectedId);
  }

  // calculates the total cost of all items and the
  // shipping (this example does not include tax)
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
    const resultsSpan = document.getElementById('orderResults');

    // remove classes from success/failure text
    // to allow multiple clicks for testing jwt.
    // normally this would not be needed as it should
    // route to another page for order results
    resultsSpan.classList.remove('text-success');
    resultsSpan.classList.remove('text-danger');

    this.orderService.createOrder(this.order)
      .subscribe(data => {
        resultsSpan.innerText = "Success!";
        resultsSpan.classList.add('text-success');
      },
        error => {
          if (error['status'] === 401) {
            resultsSpan.innerText = 'You must log in to submit an order';
          } else {
            resultsSpan.innerText = "An error occurred. Please try again later.";
          }
          resultsSpan.classList.add('text-danger');
        });
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment, ApiPaths } from '../../../environments/environment';
import { Order } from '../models/order.model';

@Injectable({ providedIn: 'root' })
export class OrderService {
  constructor(private http: HttpClient) {

  }

  createOrder(order: Order) {
    //console.log(environment.apiUrl + ApiPaths.Order + '/Create');
    //const options = { headers: { 'Content-Type': 'application/json' } };
    //return this.http.post<Order>(environment.apiUrl +
    //  ApiPaths.Order, order, options);
    //JSON.stringify(order)
    this.http.post<Order>(environment.apiUrl +
      ApiPaths.Order, order).subscribe();
  }
}



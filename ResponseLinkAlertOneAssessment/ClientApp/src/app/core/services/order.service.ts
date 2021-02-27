import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment, ApiPaths } from '../../../environments/environment';
import { Order } from '../models/order.model';

@Injectable({ providedIn: 'root' })
export class OrderService {
  constructor(private http: HttpClient) {

  }

  // posts the order to the API for database storage
  createOrder(order: Order) {
    const headers = new HttpHeaders()
      .set('Authorization', 'Bearer ' + localStorage.getItem('jwt'));
    return this.http.post<Order>(environment.apiUrl +
      ApiPaths.Order, order, { headers: headers });
  }
}



"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Order = void 0;
var address_model_1 = require("./address.model");
var customer_model_1 = require("./customer.model");
var Order = /** @class */ (function () {
    function Order() {
        this.customer = new customer_model_1.Customer();
        this.billingAddress = new address_model_1.Address();
        this.shippingAddress = new address_model_1.Address();
    }
    return Order;
}());
exports.Order = Order;
//# sourceMappingURL=order.model.js.map
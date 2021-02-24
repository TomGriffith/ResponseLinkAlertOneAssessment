import { Component, Input } from '@angular/core';
import { StateService } from '../core/services/state.service';
import { Address } from '../core/services/address.service';

@Component({
    selector: 'app-address',
    templateUrl: './address.component.html',
    styleUrls: ['./address.component.css']
})
/** Address component*/
export class AddressComponent {
  states = StateService.getStates();
  @Input() address: Address;
  @Input() disabled: boolean;

  // this is used to separate the components IDs
  @Input() addressType: string;

    /** Address ctor */
  constructor() {
  }
}

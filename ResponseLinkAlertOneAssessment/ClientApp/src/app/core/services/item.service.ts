import { Injectable } from '@angular/core';
import { IItem } from '../models/iItem.model';

@Injectable({
  providedIn: 'root',
})
export class ItemService {
  private static imagesPath = ".\\assets\\images\\items\\";

  constructor() {}

  static getItems() {
    //normally this would call an API to retrieve the item data
    //for this exercise I will fill the array of items manually
    return [
      {
        id: 1,
        name: "Parkway Drive - Reverence CD",
        cost: 13.99,
        quantity: 1,
        description: "The sixth studio album by the Australian metalcore band Parkway Drive.  Includes hit songs Prey, The Void, and Shadow Boxing.",
        imagePath: this.imagesPath + "220px-Parkway_Drive_-_Reverence.jpg"
      },
      {
        id: 2,
        name: "The Rising Of The Shield Hero Season 1 Part 1 - Blu Ray/DVD",
        cost: 29.99,
        quantity: 1,
        description: "Naofumi Iwatani is summoned into another world as one of four heros.  Known as the weakest of four heroes, the Shield Hero, he is betrayed and belittled from the start.  Will this hero-turned-cynic still be willing to fight?  Season 1 Part 1 contains episodes 1-13 of this fantastic saga.",
        imagePath: this.imagesPath + "the-rising-of-the-shield-hero-s1-p1-blu-ray.jpg"
      },
      {
        id: 3,
        name: "The Curse of Oak Island Bobby Dazzler Die Cut Sticker",
        cost: 4.95,
        quantity: 2,
        description: "It's always exciting when expert metal detector Gary Drayton finds a \"bobby dazzler\" on Oak Island.  Enjoy this excitement all the time with the new \"It's a real bobby dazzler\" sticker.",
        imagePath: this.imagesPath + "Oak-Island-BD-sticker_720x.png"
      },
      {
        id: 4,
        name: "COFFIG - Roasted Fig Coffee Replacement",
        cost: 13.75,
        quantity: 1,
        description: "COFFIG is a caffeine free, gluten free, heart healthy alternative to coffee.  Made from 100% roasted black figs.  Experience the taste of coffee even if you have dietary restrictions!",
        imagePath: this.imagesPath + "coffig.jpg"
      }
    ] as IItem[];
  }

}

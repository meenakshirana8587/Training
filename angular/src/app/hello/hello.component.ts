import { Component, OnInit } from '@angular/core';
import { product } from '../products';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})
export class HelloComponent implements OnInit {
  
  products: product[]=[];

  constructor() { }

  ngOnInit(): void {
    this.products=this.getproducts();
  }
  getproducts(): product[]{
    return[
      {
        Id :1,
        Title:"Bat",
        Color :"English Willow",
        ExpiryDate : "1-1-2050",
        Price : 4999,
      },
      {
        Id :2,
        Title:"Ball",
        Color :"SG Club",
        ExpiryDate : "1-1-2025",
        Price : 1200
      },
      {
        Id :3,
        Title:"Batting Pads",
        Color :"SS",
        ExpiryDate : "1-1-2030",
        Price : 3600
      },
      {
        Id :4,
        Title:"Kitbag",
        Color :"SG Maxipack",
        ExpiryDate : "1-1-2050",
        Price : 12000
      },
      {
        Id :5,
        Title:"Batting Gloves",
        Color :"New Balance",
        ExpiryDate : "1-1-2035",
        Price : 2200
      },
      {
        Id :6,
        Title:"Batting Helmet",
        Color :"Masuri",
        ExpiryDate : "1-1-2040",
        Price : 3000
      },
    ]
  }
}

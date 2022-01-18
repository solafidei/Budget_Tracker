import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "./product.model";

@Injectable({ providedIn: 'root'})
export class ProductService {
  private products: Product[] = [];

  constructor(private http: HttpClient) {}

  getBankProduct(bankID : number)
  {
    return this.http.get<Product[]>('/api/product/'+bankID);
  }
}

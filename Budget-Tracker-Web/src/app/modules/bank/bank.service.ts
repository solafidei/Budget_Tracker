import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Bank } from "./bank.model";

@Injectable({ providedIn: 'root'})
export class BankService {
  constructor(private http: HttpClient) {}

  getBanks() : Observable<Bank[]>{
    return this.http.get<Bank[]>('/api/bank');
  }
}

import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Subject } from "rxjs";
import { Account } from "./account.model";

@Injectable({ providedIn: 'root'})
export class AccountService {
  private accounts: Account[] = [];
  private accountUpdated = new Subject<Account[]>();

  constructor(private http: HttpClient, private router: Router) {}

  getAccounts() {
    this.http.get<Account[]>('/api/account').subscribe(transformedAccount => {
      this.accounts = transformedAccount;
      this.accountUpdated.next([...this.accounts]);
    });
  }

  getAccountsUpdatedListener() {
    return this.accountUpdated.asObservable();
  }

  addAccount(productID: number, accountNumber: number, runningBalance: number){
    const account : Account = {accountNumber: accountNumber, runningBalance: runningBalance, productId: productID };
    this.http.post<Account>('/api/account', account).subscribe(responseData => {
      const accountId = responseData.id;
      this.accounts.push(account);
      account.id = accountId;
      this.accountUpdated.next([...this.accounts]);
      this.router.navigate(['/accounts']);
    });
  }
}

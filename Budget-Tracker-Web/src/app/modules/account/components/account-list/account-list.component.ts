import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { Subscription } from 'rxjs';
import { AccountService } from '../../account.service';
import { Account } from '../../account.model';
import { MatDialog } from '@angular/material/dialog';
import { AccountCreateComponent } from '../account-create/account-create.component';

@Component({
  selector: 'app-account-list',
  templateUrl: './account-list.component.html',
  styleUrls: ['./account-list.component.scss']
})
export class AccountListComponent implements OnInit {
  accounts: Account[] = [];
  private accountSub : Subscription = new Subscription;
  constructor(public accountService: AccountService, public dialog: MatDialog, private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.spinner.show();
    this.accountService.getAccounts();
    this.accountSub = this.accountService.getAccountsUpdatedListener().subscribe((accounts: Account[]) => {
      this.spinner.hide();
      this.accounts = accounts;
    });
  }

  openDialog(){
    const dialogRef = this.dialog.open(AccountCreateComponent);

    dialogRef.afterClosed().subscribe(result => {
      window.location.reload();
    });
  }
}

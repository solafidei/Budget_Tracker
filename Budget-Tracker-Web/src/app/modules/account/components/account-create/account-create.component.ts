import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Bank } from 'src/app/modules/bank/bank.model';
import { BankService } from 'src/app/modules/bank/bank.service';
import { Product } from 'src/app/modules/product/product.model';
import { ProductService } from 'src/app/modules/product/product.service';
import { Account } from '../../account.model';
import { AccountService } from '../../account.service';

@Component({
  selector: 'app-account-create',
  templateUrl: './account-create.component.html',
  styleUrls: ['./account-create.component.scss']
})
export class AccountCreateComponent implements OnInit {
  @Input() public account: Account | undefined;
  banks: Bank[] = [];
  products: Product[] = [];

  constructor(public accountService: AccountService, public bankService: BankService, public productService: ProductService, public diag: MatDialog, public route: ActivatedRoute) { }

  ngOnInit(): void {
    this.bankService.getBanks().subscribe(result => {
      this.banks = result;
    });
  }

  getProduct(bankID: any){
    this.productService.getBankProduct(bankID).subscribe(result => {
      this.products = result;
    });
  }

  onCreateAccount(form: NgForm){
    if (form.valid)
    {
      this.accountService.addAccount(form.value.productDropDown, form.value.accountNumber, form.value.runningBalance);
      this.diag.closeAll();
    }
  }
}

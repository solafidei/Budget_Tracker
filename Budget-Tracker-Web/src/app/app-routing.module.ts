import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AccountCreateComponent } from "./modules/account/components/account-create/account-create.component";
import { AccountListComponent } from "./modules/account/components/account-list/account-list.component";
import { TransactionCreateComponent } from "./modules/transaction/components/transaction-create/transaction-create.component";
import { TransactionListComponent } from "./modules/transaction/components/transaction-list/transaction-list.component";


const routes : Routes = [
  {path: 'accounts', component: AccountListComponent},
  {path: 'account/create', component: AccountCreateComponent},
  {path: 'account/:accountId', component: TransactionListComponent},
  {path: 'account/:accountId/create', component: TransactionCreateComponent}
]
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}

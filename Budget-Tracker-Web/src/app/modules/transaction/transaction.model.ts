export interface Transaction {
  id: number,
  amount: number,
  transactionDate: Date,
  description: string,
  bankCharge: number | null,
  transactionTypeId: number,
  accountId: number
  bankId: number,
  productId: number
}

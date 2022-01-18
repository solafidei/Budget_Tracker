import { Bank } from "../bank/bank.model";

export interface Product{
  id: number,
  name: string,
  bankId: number,
  bank?: Bank
}

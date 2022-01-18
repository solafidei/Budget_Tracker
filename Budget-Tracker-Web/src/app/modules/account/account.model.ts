import { Product } from "../product/product.model";

export interface Account {
        id?: number,
        accountNumber: number,
        runningBalance: number,
        productId: number,
        product?: Product
}

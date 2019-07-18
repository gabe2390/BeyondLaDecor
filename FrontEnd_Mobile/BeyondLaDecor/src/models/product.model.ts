import { ProductType } from "./product-type.model";

export interface Product {
    productId : number,
    name :string,
    description :string,
    thirdParty : boolean,
    productType : ProductType
}
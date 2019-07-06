import { ProductType } from "./product-type.model";

export interface Product {
    productId : number,
    name :string,
    descritption :string,
    thirdParty : boolean,
    productType : ProductType
}
import { ProductType } from "./product-type.model";

export interface Product {
    ProductId : number,
    Name :string,
    Descritption :string,
    ThirdParty : boolean,
    ProductType : ProductType
}
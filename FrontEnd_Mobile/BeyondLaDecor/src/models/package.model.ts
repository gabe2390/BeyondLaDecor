import { Product } from "./product.model";
import { Service } from "./service.model";

export interface Package{
    packageId :number,
    name : string,
    services : Service[],
    products : Product[],
    capacity : number,
    isCustom : boolean
} 
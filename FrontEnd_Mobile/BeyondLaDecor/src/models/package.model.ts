import { Product } from "./product.model";
import { Service } from "./service.model";

export interface Package{
    PackageId :number,
    Name : string,
    Services : Service[],
    Products : Product[]
} 
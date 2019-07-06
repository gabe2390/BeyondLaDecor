import { ServiceType } from "./service-type.model";

export interface Service {
    serviceId : number,
    name :string,
    description :string,
    thirdParty : boolean,
    serviceType : ServiceType
}
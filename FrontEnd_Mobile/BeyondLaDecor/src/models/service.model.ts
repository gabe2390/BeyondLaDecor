import { ServiceType } from "./service-type.model";

export interface Service {
    ServiceId : number,
    Name :string,
    Description :string,
    ThirdParty : boolean,
    ServiceType : ServiceType
}
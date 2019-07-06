import { Setting } from "./setting.model";

export interface User{
    isAdministrator : boolean,
    firstName : string,
    lastName : string,
    userName : string,
    email : string,
    address? : string,
    city? : string,
    state? : string,
    events? : Event | Event[],
    settings : Setting[]
}
import { User } from "./user.model";
import { Package } from "./package.model";
import { Location } from "./location.model";

export interface Event{
    EventId : number,
    Client  : User,
    Planner : User,
    Package : Package
    Date : Date,
    Locations : Location | Location[]
}
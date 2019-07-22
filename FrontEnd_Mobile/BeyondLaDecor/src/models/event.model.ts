import { User } from "./user.model";
import { Package } from "./package.model";
import { Location } from "./location.model";
import { EventType } from "./event-type.model";

export interface Event {
    eventId: number,
    eventType : EventType
    client: User,
    planner?: User,
    package: Package
    date: Date,
    locations: Location[],
    cost : number
}
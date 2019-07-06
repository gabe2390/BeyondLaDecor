import { User } from "./user.model";
import { Package } from "./package.model";
import { Location } from "./location.model";

export interface Event {
    eventId: number,
    client: User,
    planner: User,
    package: Package
    date: Date,
    locations: Location | Location[]
}
import { Event } from "../models/event.model";

export type FilteringMethod = (a: Event, propertyValue: any) => boolean;
let eventTypeFilter: FilteringMethod = (a: Event, b: string) => {
    return a.eventType.name === b;
};
let packageFilter: FilteringMethod = (a: Event, b: number) => {
    return a.package.packageId === b;
};
let empty: FilteringMethod = (a: Event, b: any) => true;
export let FilteringMethods = {
    eventTypeFilter: eventTypeFilter,
    packageFilter: packageFilter,
    empty: empty
}
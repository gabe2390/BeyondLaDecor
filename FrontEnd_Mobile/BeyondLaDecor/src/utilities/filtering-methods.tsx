import { Event } from "../models/event.model";

export type FilteringMethod = (a: Event, propertyValue: any) => boolean;
export type DateRange = { startDate: Date, endDate: Date };

let eventTypeFilter: FilteringMethod = (a: Event, b: string): boolean => {
    return a.eventType.name === b;
};
let packageFilter: FilteringMethod = (a: Event, b: number): boolean => {
    return a.package.packageId === b;
};
let empty: FilteringMethod = (a: Event, b: any): boolean => true;

let dateRangeFilter: FilteringMethod = (a: Event, dates: DateRange): boolean => {
    return a.date >= dates.endDate && a.date <= dates.startDate;
}

export let FilteringMethods = {
    eventTypeFilter: eventTypeFilter,
    packageFilter: packageFilter,
    dateRangeFilter: dateRangeFilter,
    empty: empty
}

import { Event } from "../models/event.model";

export type SortingMethod = (a: any, b: any) => number;
let eventDate: SortingMethod = (a: Event, b: Event) => {
    return a.date > b.date ? 1 : b.date > a.date ? -1 : 0;
};
let eventType: SortingMethod = (a: Event, b: Event) => {
    return a.eventType.name > b.eventType.name ? 1 : a.eventType.name < b.eventType.name ? -1 : 0;
};
let cost: SortingMethod = (a: Event, b: Event) => {
    return a.cost > b.cost ? 1 : a.cost < b.cost ? -1 : 0;
};

let empty: SortingMethod = (a: Event, b: Event) => 0
export let SortingMethods = {
    eventDate: eventDate,
    eventType: eventType,
    cost: cost,
    empty: empty
};
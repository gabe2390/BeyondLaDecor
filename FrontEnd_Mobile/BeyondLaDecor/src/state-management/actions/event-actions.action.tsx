import { EVENT_VIEW_ACTION_CONSTANTS } from "../../constants/constants";
import { FilteringMethod } from "../../utilities/filtering-methods";
import { SortingMethod } from "../../utilities/sorting-methods";


export function loadEvents(payload: Event[]) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.LOAD_EVENTS, payload };
};
export function changeFilteringMethod(payload: FilteringMethod) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_FILTERING_METHOD, payload };
}

export function changeSortingMethod(payload: SortingMethod) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_SORTING_METHOD, payload };
}

export function changeStartDateRange(payload: Date) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_START_DATE_RANGE, payload };
}

export function changeEndDateRange(payload: Date) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_END_DATE_RANGE, payload };
}

export function toggleView(payload: boolean) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.TOGGLE_VIEW, payload };
}

export let EventViewActions = {
    loadEvents: loadEvents,
    changeFilteringMethod: changeFilteringMethod,
    changeSortingMethod: changeSortingMethod,
    changeStartDateRange: changeStartDateRange,
    changeEndDateRange: changeEndDateRange,
    toggleView: toggleView
}
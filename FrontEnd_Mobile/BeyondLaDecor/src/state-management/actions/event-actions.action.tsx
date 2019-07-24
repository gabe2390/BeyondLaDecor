import { EVENT_VIEW_ACTION_CONSTANTS } from "../../constants/constants";


export function loadEvents(payload: any) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.LOAD_EVENTS, payload };
};
export function changeFilteringMethod(payload: any) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_FILTERING_METHOD, payload };
}

/ function changeSortingMethod(payload: any) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_SORTING_METHOD, payload };
}

export function changeStartDateFilter(payload: any) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_START_DATE_FILTER, payload };
}

export function changeEndDateFilter(payload: any) {
    return { type: EVENT_VIEW_ACTION_CONSTANTS.CHANGE_END_DATE_FILTER, payload };
}
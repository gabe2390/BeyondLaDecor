import { EVENT_VIEW_ACTION_CONSTANTS } from "../../constants/constants";
import { EventViewState } from "../../views/event-view.component";
import { FilteringMethods, DateRange } from "../../utilities/filtering-methods";
import { SortingMethods } from "../../utilities/sorting-methods";
import { DateHelper } from "../../utilities/date-functions";

const intialState: EventViewState = {
    dateRange: { startDate: DateHelper.monthsFrom(-12), endDate: DateHelper.monthsFrom(12) },
    events: [],
    loading: true,
    filteringMethod: FilteringMethods.empty,
    sortingMethod: SortingMethods.empty,
};
function eventViewReducer(state: EventViewState = intialState, action: any): EventViewState {
    switch (action.type) {
        //go to home page
        case EVENT_VIEW_ACTION_CONSTANTS.LOAD_EVENTS:
            return { ...state, events: action.payload };
        case EVENT_VIEW_ACTION_CONSTANTS.CHANGE_FILTERING_METHOD:
            return { ...state, filteringMethod: action.payload };
        case EVENT_VIEW_ACTION_CONSTANTS.CHANGE_SORTING_METHOD:
            return { ...state, sortingMethod: action.payload };
        case EVENT_VIEW_ACTION_CONSTANTS.CHANGE_START_DATE_RANGE:
            return { ...state, dateRange: { ...state.dateRange, startDate: action.payload } };
        case EVENT_VIEW_ACTION_CONSTANTS.CHANGE_END_DATE_RANGE:
            return { ...state, dateRange: { ...state.dateRange, endDate: action.payload } };
        case EVENT_VIEW_ACTION_CONSTANTS.TOGGLE_VIEW:
            return { ...state, loading: action.payload }
        default: return state;
    };
}
export default eventViewReducer;
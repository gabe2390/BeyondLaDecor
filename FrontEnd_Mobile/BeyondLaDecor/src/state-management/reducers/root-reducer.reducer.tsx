import { ROOT_ACTIONS } from "../actions/root-actions.action";
import { ROOT_ACTION_CONSTANTS } from "../../constants/constants";
import { Action } from "redux";

const initialState: any = {
    loggedIn: false,
    viewingRegistration: false
};
function rootReducer(state = initialState, action: Action) {
    switch (action.type) {
        case ROOT_ACTION_CONSTANTS.LOGIN: {
            break;
        }
        case ROOT_ACTION_CONSTANTS.VIEW_LOGIN: {
            break;
        }
        case ROOT_ACTION_CONSTANTS.REGISTER: {
            break;
        }
        case ROOT_ACTION_CONSTANTS.VIEW_REGISTRATION: {
            break;
        }
    }
};
export default rootReducer;
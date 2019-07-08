import { ROOT_ACTION_CONSTANTS } from "../../constants/constants";
import { AppState } from "../../views/IntialScreen";

const initialState: AppState = {
    loggedIn: false,
    loginIndex: 0
};
function rootReducer(state: AppState = initialState, action: any): AppState {
    switch (action.type) {
        //go to home page
        case ROOT_ACTION_CONSTANTS.LOGIN:
            return { ...state, loggedIn: action.sucessfulLogin ? true : false };
        //go to new user workflow
        case ROOT_ACTION_CONSTANTS.REGISTER:
            return { ...state, loggedIn: action.sucessfulLogin ? true : false };
        //toggle between login and registration views
        case ROOT_ACTION_CONSTANTS.TOGGLE_LOGIN_VIEW:
            return { ...state, loginIndex: action.payload };
        default: return state;
    };
}
export default rootReducer;
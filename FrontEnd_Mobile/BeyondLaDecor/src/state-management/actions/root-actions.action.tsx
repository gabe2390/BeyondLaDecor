import { ROOT_ACTION_CONSTANTS } from "../../constants/constants";

function login(payload: {}) {
  return { type: ROOT_ACTION_CONSTANTS.LOGIN, payload }
};
function viewLogin(payload: {}) {
  return { type: ROOT_ACTION_CONSTANTS.VIEW_LOGIN, payload }
}
function register(payload: {}) {
  return { type: ROOT_ACTION_CONSTANTS.REGISTER, payload }
}
function viewRegistration(payload: {}) {
  return { type: ROOT_ACTION_CONSTANTS.VIEW_REGISTRATION, payload }
}
export var ROOT_ACTIONS = {
  login: login,
  viewLogin: viewLogin,
  register: register,
  viewRegistration: viewRegistration
}
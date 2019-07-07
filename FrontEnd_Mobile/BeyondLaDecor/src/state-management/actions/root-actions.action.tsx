import { ROOT_ACTION_CONSTANTS } from "../../constants/constants";

export function login(payload: any) {
  return { type: ROOT_ACTION_CONSTANTS.LOGIN, payload };
};
export function register(payload: any) {
  return { type: ROOT_ACTION_CONSTANTS.REGISTER, payload };
}

export function toggleLoginView(payload: any) {
  return { type: ROOT_ACTION_CONSTANTS.TOGGLE_LOGIN_VIEW, payload };
}
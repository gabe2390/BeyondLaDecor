import { createStore } from "redux";
import rootReducer from "./reducers/root-reducer.reducer";

const laDecorStore = createStore(rootReducer);
export default laDecorStore;
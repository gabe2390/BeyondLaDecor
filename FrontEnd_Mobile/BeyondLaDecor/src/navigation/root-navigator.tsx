import { Home } from "../views/home.component";
import { Login } from "../views/login.component";
import SideBar from "./side-bar";
import { createDrawerNavigator, Header, createAppContainer } from 'react-navigation';
import { AddWorkflow } from "../views/admin/add-workflow.component";

const RootNavigator = createDrawerNavigator(
    {
        HomeScreen: { screen: Home },
        LoginScreen: { screen: Login },
        AddWorkflowScreen: { screen: AddWorkflow },
    },
    {
        contentComponent: (props: any) => <SideBar {...props} />,
        drawerPosition: 'left'
    }
);
const Navigation = createAppContainer(RootNavigator);

export default Navigation;
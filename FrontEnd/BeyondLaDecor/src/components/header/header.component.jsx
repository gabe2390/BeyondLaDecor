import React from 'react';

import Menu from './menu/menu.component';

require('./menu.component.scss');

export default class Header extends React.Component {
    constructor() {
        super();
        this.state = {
        }
    }   

    render() {
        return (
            <div className="header-container">
                <div className="menu-container">
                    <Menu></Menu>  
                    Menu Holder                  
                </div>
                <div className="logo-container">Logo</div>
            </div>
        );
    }
}
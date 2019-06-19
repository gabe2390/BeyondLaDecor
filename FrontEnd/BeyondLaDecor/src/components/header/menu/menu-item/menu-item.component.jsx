import React from 'react';

require('./menu.component.scss');

export default class MenuItem extends React.Component {
    constructor() {
        super();
        this.state = {
        }
    }
    
    render() {
        return (
            <div className="menu-items-container">
                {this.buildMenu()}
            </div>
        );
    }
}
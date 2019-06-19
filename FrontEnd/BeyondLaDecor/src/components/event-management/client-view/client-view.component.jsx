import React from 'react';

require('./client-view.component.scss');

export default class ClientView extends React.Component {
    constructor() {
        super();
        this.state = {            
        }
    }

    render() {
        return (
            <div className="view-manager-container">
            </div>
        );
    }
}
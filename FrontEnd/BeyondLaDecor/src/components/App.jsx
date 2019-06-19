import React from 'react';
import update from 'immutability-helper';
import Modal from 'react-modal';
import axios from 'axios';

import SelectPlayers from './select-player/select-players.component';
import CreatePlayer from './create-player/create-player.component';
import Player from './player/player.component';
import PoolManager from './pool-manager/pool-manager.component';
import DeclareWinner from './declare-winner/declare-winner.component';
import SelectedPlayers from './selected-players/selected-players.component';
import LeaderBoard from './leaderboard/leaderboard.component';

require('./App.scss');

export default class App extends React.Component {
    constructor() {
        super();
        this.state = {
            loggedIn: false,
        }
    }
    componentWillMount() {
        Modal.setAppElement('body');
    }
    componentDidMount() {
        this.retrieveUserDetails();
    }

    retrieveUserDetails() {
        axios.get("http://localhost:5000/users/").then((response) => {
            this.setState(update(this.state, { $merge: { players: response.data } }))
        }).catch(() => {
            //TODO: error handling if data doesn't load
        });
    }

    linkClientOrAdministrator(newPlayer) {
        axios.post("http://localhost:5000/api/players", newPlayer).then(response => {
            let players = update(this.state.players, { $push: [newPlayer] });
            this.setState(update(this.state, { $merge: { players: players, creatingNewPlayer: false } }));
        }).catch(() => {
            //TODO: error handling if error occurs
        });
    } 

    render() {
        return (
            <div className='app-container'>             
                <Header></Header>
                {this.getCurrentView()}
                <Footer></Footer>
            </div>
        )
    }
}

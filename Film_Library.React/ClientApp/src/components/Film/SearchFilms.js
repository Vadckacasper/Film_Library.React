import React, { Component } from 'react';
import { Button, Form, Input } from 'reactstrap';


export class SearchFilms extends Component {

    constructor(props){
        super(props);
        this.state = {value: ''};
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit() {
        
    }

    render() {
        return (
            <form className="d-flex" onSubmit={this.handleSubmit()}>
                <input className="d-flex" type="search" placeholder="Поиск" aria-label="Search"/>
                <input className="btn btn-primary" type="submit" value="Поиск" />
            </form>
            );
    }
}



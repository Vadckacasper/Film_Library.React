import React, { Component } from "react";
import { Search } from "../Search/Search";
import { ListFilms } from "../ListFilms/ListFilms";


export class Films extends Component {

  constructor(props) {
    super(props);
    this.state = { films: [], loading: true};
    this.UpdateFilms = this.UpdateFilms.bind(this);
  }


  componentDidMount(){
    this.LoadFilms();
  }

  async LoadFilms(){
    let response = await fetch("api/Films");
    if(response.ok)
    {
    let data = await response.json();
    this.setState({films: data, loading: false});
    }else
    {
        this.setState({loading: true});
        alert(response.status);
    }
  }

  UpdateFilms(value){
    this.setState({films: value});
  }

  render() {
    return(
        <div>
        <Search updateFilms={this.UpdateFilms}/>
        <ListFilms films={this.state.films} loading={this.state.loading} />
        </div>
    );
  }
}

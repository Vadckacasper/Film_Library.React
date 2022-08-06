import React, { Component } from "react";
import "./CardFilm.css";

export class CardFilm extends Component {
  constructor(props) {
    super(props);
  }
  
  OpenCard(){

  }

  render() {
    const film = this.props.filmCard;
    return (
      <div className="card cardFilm" to="/pageFilms" >
        <img src={film.path_Img} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">{film.name}</h5>
          <p className="card-text">{film.shortDescription}</p>
        </div>
      </div>
    );
  }
}

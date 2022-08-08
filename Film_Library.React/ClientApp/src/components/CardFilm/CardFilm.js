import React, { Component } from "react";
import "./CardFilm.css";

export class CardFilm extends Component {
  constructor(props) {
    super(props);
  }

  renderActorData(fullNameActors) {
    return fullNameActors.map((actorName, key) => (
      <li className="list-inline-item" key={key}>
        {actorName},
      </li>
    ));
  }

  render() {
    const film = this.props.filmCard;
    const actor = this.renderActorData(film.fullNameActors);
    return (
      <div className="card cardFilm" to="/pageFilms">
        <img src={film.pathImg} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">{film.name}</h5>
          <p className="card-text">{film.shortDescription}</p>
        </div>
        <div className="card-futer">
          <div className="card-body">
            <ul className="list-inline">Актеры: {actor}</ul>
          </div>
        </div>
      </div>
    );
  }
}

import React, { Component } from "react";
import { Link } from "react-router-dom";
import { CardFilm } from "../CardFilm/CardFilm";
import "./ListFilms.css"

export class ListFilms extends Component {
  constructor(props) {
    super(props);
  }

  renderFilmsData(films) {
    return films.map((film, key) => (
      <Link className="col-lg-4 col-md-6 card-film" to={`/film/${film.id}`} key={key}>
        <CardFilm filmCard={film} />
      </Link>
    ));
  }

  render() {
    let contents = this.props.loading ? (
      <p>
        <em>Загрузка...</em>
      </p>
    ) : (
      this.renderFilmsData(this.props.films)
    );

    return (
      <div>
        <h1>Список Фильмов</h1>
        <div className="row">{contents}</div>
      </div>
    );
  }
}

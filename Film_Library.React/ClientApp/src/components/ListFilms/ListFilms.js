import React, { Component } from "react";
import { Link } from "react-router-dom";
import { CardFilm } from "../CardFilm/CardFilm";
import { CardGroup } from "reactstrap";

export class ListFilms extends Component {
  constructor(props) {
    super(props);
  }

  renderFilmsData(films) {
    console.log(films);
    return films.map((film, key) => (
      <Link to={`/${film.id}`} key={key}>
        <CardFilm filmCard={film} />
      </Link>
    ));
  }

  render() {
    let contents = this.props.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      this.renderFilmsData(this.props.films)
    );
    return (
      <div>
        <h1>Список Фильмов</h1>
        <CardGroup>{contents}</CardGroup>
      </div>
    );
  }
}

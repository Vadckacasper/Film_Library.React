import React, { Component } from "react";
import { SearchFilms } from "./SearchFilms";
import { CardFilm } from "./CardFilm";
import {CardGroup} from 'reactstrap'

export class ListFilms extends Component {
  static displayName = ListFilms.name;

  constructor(props) {
    super(props);
    this.state = { films: [], loading: true };
  }

  componentDidMount() {
    this.populateFilmData();
  }

  static renderFilmsData(films) {
    return films.map((film) => <CardFilm filmCard={film} key={film.id} />);
  }

  render() {
    let contents = this.state.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      ListFilms.renderFilmsData(this.state.films)
    );
    return (
      <div>
        <SearchFilms />

        <h1>Список Фильмов</h1>
        <CardGroup>{contents}</CardGroup>
      </div>
    );
  }

  async populateFilmData() {
    const response = await fetch("api/Films");
    const data = await response.json();
    this.setState({ films: data, loading: false });
  }
}

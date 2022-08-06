import React, { Component } from "react";
import { SearchFilms } from "./SearchFilms";
import {CardGroup, Card, CardBody, CardTitle, CardText, CardImg} from 'reactstrap'

class CardFilms extends Component {
  constructor(props) {
    super(props);
  }
  render() {
    const film = this.props.filmCard;
    return (
      <Card style={{width:'18rem', margin: '5px'}}>
        <CardImg src={film.path_Img} width="100%" />
        <CardBody>
          <CardTitle>{film.name}</CardTitle>
          <CardText>{film.shortDescription}</CardText>
        </CardBody>
      </Card>
    );
  }
}

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
    return films.map((film) => <CardFilms filmCard={film} key={film.id} />);
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

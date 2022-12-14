import React, { Component } from "react";

export class Search extends Component {
  constructor(props) {
    super(props);
    this.state = { value: "" };
    this.handleSubmit = this.handleSubmit.bind(this);
    this.handleChange = this.handleChange.bind(this);
  }

  handleChange(event) {
    this.setState({ value: event.target.value });
  }

  async handleSubmit(event) {
    await event.preventDefault();

    let response;
    if (this.state.value === "") {
      response = await fetch(`api/Films`);
    } else {
      response = await fetch(`api/Films/_search/${this.state.value}`);
    }

    if (response.ok) {
      const data = await response.json();
      this.props.updateFilms(data);
      this.setState({ value: "" });
    }
  }

  render() {
    return (
      <form className="d-flex" onSubmit={this.handleSubmit}>
        <input
          className="form-control mr-2"
          type="search"
          placeholder="Фильмы, жанры, актеры"
          aria-label="Поиск"
          value={this.state.value}
          onChange={this.handleChange}
        />
        <button className="btn btn-outline-primary" type="submit">
          Поиск
        </button>
      </form>
    );
  }
}

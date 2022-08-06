import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Здравствуйте, это сайт для поиска фильмов.</h1>
      </div>
    );
  }
}

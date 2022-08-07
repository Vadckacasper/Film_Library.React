import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Films } from './components/Films/Films';
import { PageFilm } from './components/PageFilm/PageFilm';

import './custom.css'

export default class App extends Component {

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route excat path='/films' component={Films} />
        <Route path='/film/:id' component={PageFilm}/>
      </Layout>
    );
  }
}

import React, { Component } from 'react';

export class ListFilms extends Component {
    static displayName = ListFilms.name;

    constructor(props) {
        super(props);
        this.state = { films: [], loading: true}
    }

    componentDidMount() {
        this.populateFilmData();
    }

    static renderFilmsData(films) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name (C)</th>
                        <th>ShortDesc (F)</th>
                        <th>FullDesc</th>
                    </tr>
                </thead>
                <tbody>
                    {films.map(film =>
                        <tr key={film.id}>
                            <th>{film.id}</th>
                            <td>{film.name}</td>
                            <td>{film.shortDescription}</td>
                            <td>{film.fullDescription}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : ListFilms.renderFilmsData(this.state.films);
        return (
            <div>
                <h1 id="tabelLabel">Список Фильмов</h1>
                { contents}
            </div>
            );
    }

    async populateFilmData() {
        const response = await fetch('api/Films');
        const data = await response.json();
        this.setState({ films: data, loading: false });
    }
}

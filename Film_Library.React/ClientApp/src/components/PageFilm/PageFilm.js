import React from "react";
import { useParams } from "react-router-dom";
import { useState, useEffect } from "react";
import "./PageFilm.css";
import { ListActors } from "../ListActors/ListActors";

export function PageFilm() {
  const [filmData, setFilmData] = useState(0);

  const params = useParams();
  const filmId = params.id;

  useEffect(() => {
    load();
  }, []);

  const load = async () => {
    const response = await fetch(`api/Films/${filmId}`);
    if (response.ok) {
      const data = await response.json();
      setFilmData(data);
    }
  };
  const Table = () => {
    return (
      <table className="table table-borderless">
        <tbody>
          <tr>
            <th>Жанр</th>
            <td>{filmData.name}</td>
          </tr>
          <tr>
            <th>Страны</th>
            <td>{filmData.countries}</td>
          </tr>
          <tr>
            <th>Режисер</th>
            <td>{filmData.producer}</td>
          </tr>
          <tr>
            <th>Год производства</th>
            <td>{filmData.yearProduction}</td>
          </tr>
        </tbody>
      </table>
    );
  };

  return (
    <div className="row">
      <div className="col-lg-6">
        <img className="img-fluid img-film" src={filmData.pathImg} />
      </div>
      <div className="col-lg-6 table-data">{Table()}</div>
      <div className="container pt-4">{filmData.fullDescription}</div>
      <ListActors filmId={filmId} />
    </div>
  );
}

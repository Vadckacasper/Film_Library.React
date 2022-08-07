import React from "react";
import { useParams } from "react-router-dom";
import { useState, useEffect } from "react";
import "./PageFilm.css";
export function PageFilm() {
  const [filmData, setFilmData] = useState(0);

  const params = useParams();
  const prodId = params.id;

  useEffect(() => {
    load();
  }, []);

  const load = async () => {
    const response = await fetch(`api/Films/${prodId}`);
    if (response.ok) {
      const data = await response.json();
      setFilmData(data);
    }
  };

  return (
    <section className="section about-section gray-bg" id="about">
      <div className="container">
        <div className="row">
          <div className="col-lg-6">
            <img
              className="img-fluid img-film"
              src={filmData.path_Img}
            />
          </div>
          <div className="col-lg-6">
            <div className="">
              <h6 className="theme-color lead">{filmData.name}</h6>
              <p>{filmData.fullDescription}</p>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}

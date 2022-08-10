import React from "react";
import {CardActor} from "../CardActor/CardActor"
import { useState, useEffect } from "react";
import {Swiper, SwiperSlide } from "swiper/react";
import { Pagination } from "swiper";
import 'swiper/swiper-bundle.min.css';
import "./ListActors.css"

export function ListActors(props) {
    const [ActorsData, setActorsData] = useState([]);

    useEffect(() => {
      load();
    },[props.filmId]);

    const load = async () => {
      const response = await fetch(`api/Actors/_actors/${props.filmId}`);
      if (response.ok) {
        const data = await response.json();
        setActorsData(data);
      }
    };

    const renderActorsData = (actors) => {
      return actors.map((actor, key) => (
          <SwiperSlide key={key}><CardActor actorCard={actor} /></SwiperSlide>
      ));
    }

  return (
      <Swiper 
      slidesPerView={5}
      breakpoints={{
        "320": {
          slidesPerView: 1,
        },
        "480": {
          slidesPerView: 2,
        },
        "768": {
          slidesPerView: 3,
        },
        "1024": {
          slidesPerView: 4,
        },
        "1440": {
          slidesPerView: 5,
        },
        "1900": {
          slidesPerView: 6,
        },
      }}
        spaceBetween={10}
        freeMode={true}
        pagination={{
          clickable: true,
        }}
        modules={[Pagination]}
        className="mySwiper">
      {renderActorsData(ActorsData)}
      </Swiper>
  );
}





import React from "react";

export function CardActor(props) {
    const Actors = props.actorCard;
  return (
    <div className="card">
    <img src={Actors.pathImg} className="card-img-top" alt="..."/>
    <div className="card-foter">
      <h5 className="card-title">{Actors.name} {Actors.surname}</h5>
      <p className="card-text">Небольшой пример текста, который должен основываться на названии карточки и составлять основную часть содержимого карты.</p>
      <a href="#" className="btn btn-primary">Перейти куда-нибудь</a>
    </div>
  </div>
  );
}

import React from "react";
import "./CardActor.css";

export function CardActor(props) {
  const Actors = props.actorCard;
  return (
        <div className="card-actor">
          <img src={Actors.path_Img} className="img img-responsive" />
          <div className="actor-name">{Actors.fullName}</div>
        </div>
  );
}

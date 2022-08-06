import React, { Component } from "react";
import { withRouter } from "react-router";

export class PageFilm extends Component {

  constructor(props) {
    super(props);
    //this.state={classId: useParams().id};
    this.id = this.props.match.params.id;
  }

  componentDidMount(){
    this.LoadFilms();
  }

  async LoadFilms(){
    let response = await fetch(`api/Films/_id${this.id}`);
    if(response.ok)
    {
    let data = await response.json();
        console.log(data);
    }else
    {
        alert(response.status);
    }
  }

  render() {
    return(
        <p>Привет</p>
    );
  }
}
export default withRouter(PageFilm);
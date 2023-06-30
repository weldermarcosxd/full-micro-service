import "./styles.css";
import PropTypes from "prop-types";

import { Component } from "react";

export class Botao extends Component {
  static get propTypes() {
    return {
      text: PropTypes.string,
      onClick: PropTypes.func,
      disabled: PropTypes.bool,
    };
  }

  render() {
    const { text, onClick, disabled } = this.props;

    return (
      <button className="botao" onClick={onClick} disabled={disabled}>
        {text}
      </button>
    );
  }
}

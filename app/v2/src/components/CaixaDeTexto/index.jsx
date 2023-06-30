import "./styles.css";
import PropTypes from "prop-types";

import { Component } from "react";

export class CaixaDeTexto extends Component {
  static get propTypes() {
    return {
      value: PropTypes.string,
      onChange: PropTypes.func,
    };
  }

  render() {
    const { value, onChange } = this.props;

    return (
      <input
        className="text-input"
        onChange={onChange}
        value={value}
        type="search"
        placeholder="Digite a pesquisa"
      ></input>
    );
  }
}

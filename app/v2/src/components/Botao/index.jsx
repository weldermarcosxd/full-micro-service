import './styles.css';

import { Component } from "react";

export class Botao extends Component {
    render(){

        const { text, onClick, disabled } = this.props;

        return (
            <button className='botao' onClick={onClick} disabled={disabled}>
                {text}
            </button>
        )
    }
}
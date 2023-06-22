import './styles.css';

import { Component } from "react";

export class CaixaDeTexto extends Component{
    render(){

        const { value, onChange } = this.props;

        return (
            <input className='text-input' onChange={onChange} value={value} type='search' placeholder='Digite a pesquisa'></input>
        );
    }
}
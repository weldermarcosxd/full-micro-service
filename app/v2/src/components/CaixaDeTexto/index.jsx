import { Component } from "react";

export class CaixaDeTexto extends Component{
    render(){

        const { value, onChange } = this.props;

        return (
            <input onChange={onChange} value={value} type="search"></input>
        );
    }
}
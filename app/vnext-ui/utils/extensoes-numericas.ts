export class ExtensoesNumericas {
    static formatarValorMonetario(preco: number)
    {
        return new Intl.NumberFormat('pt-BR', {
            style: 'currency',
            currency: 'BRL',
        }).format(preco);
    }
    
    static formatarQuantidade(value: number)
    {
        return new Intl.NumberFormat('pt-BR').format(value)
    }
};
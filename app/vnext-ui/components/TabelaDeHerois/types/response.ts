export interface IResposta
{
  numeroDaPagina: number
  tamanhoDaPagina: number
  firstPage: any
  lastPage: any
  totalDePaginas: number
  totalDeRegistros: number
  nextPage: any
  previousPage: any
  data: Produto[]
  sucesso: boolean
  erros: any
  mensagem: any
}

export class Produto
{
  id: string
  sequencial: number
  nome: string
  descricao: string
  preco: number
  quantidadeEmEstoque: number

  get precoFormatado(): string
  {
    return this.preco.toLocaleString();
  }

  get quantidadeEmEstoqueFormatada(): string
  {
    return this.quantidadeEmEstoque.toLocaleString();
  }

  constructor(id: string, sequencial: number, nome: string, descricao: string, preco: number, quantidadeEmEstoque: number)
  {
    this.id = id;
    this.sequencial = sequencial;
    this.nome = nome;
    this.descricao = descricao;
    this.preco = preco;
    this.quantidadeEmEstoque = quantidadeEmEstoque;
  }
}

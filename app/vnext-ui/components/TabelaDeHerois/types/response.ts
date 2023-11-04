export interface IResposta {
    numeroDaPagina: number
    tamanhoDaPagina: number
    firstPage: any
    lastPage: any
    totalDePaginas: number
    totalDeRegistros: number
    nextPage: any
    previousPage: any
    produtoss: IProduto[]
    sucesso: boolean
    erros: any
    mensagem: any
  }
  
  export interface IProduto {
    id: string
    sequencial: number
    nome: string
    descricao: string
    preco: number
    quantidadeEmEstoque: number
  }
  
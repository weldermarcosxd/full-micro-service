using System;

namespace Pdi.Full.Micro.Service.Entities.Dtos
{
    public class RespostaPaginada<T> : Resposta<T>
    {
        public int NumeroDaPagina { get; set; }
        public int TamanhoDaPagina { get; set; }
        public Uri FirstPage { get; set; }
        public Uri LastPage { get; set; }
        public int TotalDePaginas => Convert.ToInt32(Math.Ceiling((decimal)TotalDeRegistros / TamanhoDaPagina));
        public int TotalDeRegistros { get; set; }
        public Uri NextPage { get; set; }
        public Uri PreviousPage { get; set; }
        
        public RespostaPaginada(T data, int pageNumber, int pageSize)
        {
            NumeroDaPagina = pageNumber;
            TamanhoDaPagina = pageSize;
            Data = data;
            Mensagem = null;
            Sucesso = true;
            Erros = null;
        }

        public RespostaPaginada(T data, FiltroDePaginacao filtro, int totalDeRegistros)
        {
            NumeroDaPagina = filtro.NumeroDaPagina;
            TamanhoDaPagina = filtro.TamanhoDaPagina;
            TotalDeRegistros = totalDeRegistros;
            Data = data;
            Mensagem = null;
            Sucesso = true;
            Erros = null;
        }
    }
}
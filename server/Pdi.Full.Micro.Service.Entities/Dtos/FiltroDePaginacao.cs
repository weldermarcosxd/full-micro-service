namespace Pdi.Full.Micro.Service.Entities.Dtos
{
    public class FiltroDePaginacao
    {
        public int NumeroDaPagina { get; set; }
        public int TamanhoDaPagina { get; set; }
        public string PesquisaTextual { get; set; }

        public FiltroDePaginacao()
        {
            NumeroDaPagina = 1;
            TamanhoDaPagina = 20;
        }
        public FiltroDePaginacao(int pageNumber, int pageSize, string pesquisaTextual)
        {
            NumeroDaPagina = pageNumber < 1 ? 1 : pageNumber;
            TamanhoDaPagina = pageSize > 20 ? 20 : pageSize;
            PesquisaTextual = pesquisaTextual;
        }
    }
}
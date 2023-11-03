namespace Pdi.Full.Micro.Service.Entities.Dtos
{
    public class FiltroDePaginacao
    {
        public int NumeroDaPagina { get; set; }
        public int TamanhoDaPagina { get; set; }

        public FiltroDePaginacao()
        {
            NumeroDaPagina = 1;
            TamanhoDaPagina = 20;
        }
        public FiltroDePaginacao(int pageNumber, int pageSize)
        {
            NumeroDaPagina = pageNumber < 1 ? 1 : pageNumber;
            TamanhoDaPagina = pageSize > 20 ? 20 : pageSize;
        }
    }
}
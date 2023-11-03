namespace Pdi.Full.Micro.Service.Entities.Dtos
{
    public class Resposta<T>
    {
        public Resposta(){}
        
        public Resposta(T data)
        {
            Sucesso = true;
            Mensagem = string.Empty;
            Erros = null;
            Data = data;
        }

        public T Data { get; set; }
        public bool Sucesso { get; set; }
        public string[] Erros { get; set; }
        public string Mensagem { get; set; }
    }
}
namespace Investimentos.Models
{
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public bool Status { get; set; }
        public string StatusMessage { get; set; } = string.Empty;
        
    }
}

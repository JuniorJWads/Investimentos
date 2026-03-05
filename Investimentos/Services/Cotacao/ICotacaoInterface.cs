using Investimentos.Models;

namespace Investimentos.Services.Cotacao
{
    public interface ICotacaoInterface
    {
        Task<ResponseModel<CotacaoModel>> Calculadora(decimal valor, DateTime dataAplic, DateTime dataFim);
       
        Task<ResponseModel<List<CotacaoModel>>> ListarTodasCotacao();

        Task<ResponseModel<CotacaoModel>> BuscarCotacaoPorId(int id);
    }
}

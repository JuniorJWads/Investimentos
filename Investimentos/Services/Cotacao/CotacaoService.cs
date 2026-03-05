using Investimentos.Data;
using Investimentos.Models;
using Microsoft.EntityFrameworkCore;

namespace Investimentos.Services.Cotacao
{
    public class CotacaoService : ICotacaoInterface
    {
        private readonly AppDbContext _ctx;
        public CotacaoService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        #region EndPoints

        public async Task<ResponseModel<List<CotacaoModel>>> ListarTodasCotacao()
        {
            ResponseModel<List<CotacaoModel>> response = new ResponseModel<List<CotacaoModel>>();
            try
            {
                var cotacoes = await _ctx.Cotacao.ToListAsync();

                response.Dados = cotacoes;
                response.StatusMessage = "Cotações listadas com sucesso.";

                return response;

            }
            catch (Exception ex)
            {
                response.StatusMessage = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseModel<CotacaoModel>> BuscarCotacaoPorId(int id)
        {
            ResponseModel<CotacaoModel> response = new ResponseModel<CotacaoModel>();
            try
            {
                var cotacao = await _ctx.Cotacao.FirstOrDefaultAsync(x => x.id == id);
               
                if(cotacao == null)
                {
                    response.StatusMessage = "Cotação não encontrada.";
                    return response;
                }

                response.Dados = cotacao;
                response.StatusMessage = "Cotação encontrada.";
                return response;
            }
            catch (Exception ex)
            {
                response.StatusMessage = ex.Message;
                response.Status = false;
                return response;
            }

        }

        public Task<ResponseModel<CotacaoModel>> Calculadora(decimal valor, DateTime dataAplic, DateTime dataFim)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}

using Investimentos.Models;
using Investimentos.Services.Cotacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Investimentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {

        private readonly ICotacaoInterface _cotacaoInterface;
        public CotacaoController(ICotacaoInterface cotacaoInterface)
        {
            _cotacaoInterface = cotacaoInterface;
        }

        [HttpGet("ListarTodasCotacoes")]
        public async Task<ActionResult<ResponseModel<List<CotacaoModel>>>> ListarTodasCotacao()
        {
            var cotacao = await _cotacaoInterface.ListarTodasCotacao();
            return Ok(cotacao);
        }

        [HttpGet("BuscarCotacaoPorId/{id}")]
        public async Task<ActionResult<ResponseModel<CotacaoModel>>> BuscarCotacaoPorId(int id)
        {
            var cotacao = await _cotacaoInterface.BuscarCotacaoPorId(id);
            return Ok(cotacao);
        }
    } 
}

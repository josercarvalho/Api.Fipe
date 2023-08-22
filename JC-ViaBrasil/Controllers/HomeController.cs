using Azure;
using JC_ViaBrasil.DTOs;
using JC_ViaBrasil.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace JC_ViaBrasil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ITabelaFipeService _service;
        private readonly IBrasilApi _brasilApi;

        public HomeController(ITabelaFipeService service, IBrasilApi brasilApi)
        {
            _service = service;
            _brasilApi = brasilApi;
        }

        [HttpGet("{codigoFipe}")]
        public async Task<IActionResult> BuscarTabela([RegularExpression("^[0-9]*$")] string codigoFipe)
        {
            var retorno = await _brasilApi.BuscarPorCodigo(codigoFipe);

            if (retorno.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(retorno.DadosRetorno);
            }
            else
            {
                return StatusCode((int)retorno.CodigoHttp, retorno.ErroRetorno);
            }
        }

        [HttpGet("{codigoFipe}/{ano}")]
        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")] string codigoFipe, int ano)
        {
            var response = await _service.BuscarPorCodigoAno(codigoFipe, ano);

            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TabelaFipeDTO dto)
        {
            var result = await _service.CreateAsync(dto);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("BuscarPorPlaca/{placa}")]
        public async Task<IActionResult> BuscarPorPlaca(string placa)
        {
            var response = await _service.BuscarPorPlaca(placa);

            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}

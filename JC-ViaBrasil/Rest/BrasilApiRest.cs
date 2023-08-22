using JC_ViaBrasil.DTOs;
using JC_ViaBrasil.Interfaces;
using JC_ViaBrasil.Models;
using System.Dynamic;
using System.Text.Json;

namespace JC_ViaBrasil.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<List<TabelaFipe>>> BuscarPorCodigo(string codigoFipe)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/fipe/preco/v1/{codigoFipe}");

            var response = new ResponseGenerico<List<TabelaFipe>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<TabelaFipe>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }        
    }
}

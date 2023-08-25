using System.Text.Json.Serialization;

namespace JC_ViaBrasil.Models
{
    public class TabelaFipe    
    {
        [JsonPropertyName("id")]
        public int? id { get; set;}

        [JsonPropertyName("valor")]
        public string? valor { get; set; }

        [JsonPropertyName("marca")]
        public string? marca { get; set; }

        [JsonPropertyName("modelo")]
        public string? modelo { get; set; }

        [JsonPropertyName("anoModelo")]
        public int anoModelo { get; set; }

        [JsonPropertyName("combustivel")]
        public string? combustivel { get; set; }

        [JsonPropertyName("codigoFipe")]
        public string? codigoFipe { get; set; }

        [JsonPropertyName("mesReferencia")]
        public string? mesReferencia { get; set; }

        [JsonPropertyName("tipoVeiculo")]
        public int tipoVeiculo { get; set; }

        [JsonPropertyName("siglaCombustivel")]
        public string? siglaCombustivel { get; set; }

        [JsonPropertyName("dataConsulta")]
        public string? dataConsulta { get; set; }

        [JsonPropertyName("placaVeiculo")]
        public string? placaVeiculo { get; set; }
    }


}

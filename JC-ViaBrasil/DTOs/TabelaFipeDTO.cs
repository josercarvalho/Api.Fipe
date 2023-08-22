using System.Text.Json.Serialization;

namespace JC_ViaBrasil.DTOs
{
    public class TabelaFipeDTO
    {    
        public int? id { get; set; }

        public string? valor { get; set; }

        public string? marca { get; set; }

        public string? modelo { get; set; }

        public int? anoModelo { get; set; }

        public string? combustivel { get; set; }

        public string? codigoFipe { get; set; }

        public string? mesReferencia { get; set; }

        public int? tipoVeiculo { get; set; }

        public string? siglaCombustivel { get; set; }

        public string? dataConsulta { get; set; }

      
        public string? placaVeiculo { get; set; }
    }
}

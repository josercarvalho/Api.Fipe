using JC_ViaBrasil.DTOs;

namespace JC_ViaBrasil.Interfaces
{
    public interface ITabelaFipeService
    {
        Task<TabelaFipeDTO> BuscarPorCodigoAno(string codigoFipe, int ano);
        Task<TabelaFipeDTO> BuscarPorPlaca(string placaVeiculo);
        Task<TabelaFipeDTO> CreateAsync(TabelaFipeDTO tabelaFipeDTO);
        //Task<TabelaFipeDTO> EditAsync(TabelaFipeDTO dto);
        //Task DeleteAsync(TabelaFipeDTO dto);
    }
}

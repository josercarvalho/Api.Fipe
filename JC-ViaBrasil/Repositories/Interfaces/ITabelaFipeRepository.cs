using JC_ViaBrasil.Models;

namespace JC_ViaBrasil.Repositories.Interfaces
{
    public interface ITabelaFipeRepository
    {
        Task<TabelaFipe> GetByPlacaAsync(string placaVeiculo);
        Task<TabelaFipe> CreateAsync(TabelaFipe tabelaFipe);
        Task EditAsync(TabelaFipe tabela);
        Task DeleteAsync(TabelaFipe tabela);
    }
}

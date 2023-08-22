using JC_ViaBrasil.Data;
using JC_ViaBrasil.Models;
using JC_ViaBrasil.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JC_ViaBrasil.Repositories
{
    public class TabelaFipeRepository : ITabelaFipeRepository
    {
        private readonly TabelaFipeDbContext _db;

        public TabelaFipeRepository(TabelaFipeDbContext db)
        {
            _db = db;
        }

        public async Task<TabelaFipe> CreateAsync(TabelaFipe tabelaFipe)
        {
            _db.Add(tabelaFipe);
            await _db.SaveChangesAsync();
            return tabelaFipe;
        }

        public async Task DeleteAsync(TabelaFipe tabela)
        {
            _db.Remove(tabela);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(TabelaFipe tabela)
        {
            _db.Update(tabela);
            await _db.SaveChangesAsync();
        }

        public async Task<TabelaFipe> GetByPlacaAsync(string placaVeiculo)
        {
            return await _db.TabelaFipe.FirstOrDefaultAsync(x => x.placaVeiculo.Equals(placaVeiculo));
        }
    }
}

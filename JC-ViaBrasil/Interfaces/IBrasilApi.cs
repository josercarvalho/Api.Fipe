using JC_ViaBrasil.DTOs;
using JC_ViaBrasil.Models;

namespace JC_ViaBrasil.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<List<TabelaFipe>>> BuscarPorCodigo(string codigoFipe);
    }
}

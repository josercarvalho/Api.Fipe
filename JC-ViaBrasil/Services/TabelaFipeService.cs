using AutoMapper;
using JC_ViaBrasil.DTOs;
using JC_ViaBrasil.Interfaces;
using JC_ViaBrasil.Models;
using JC_ViaBrasil.Repositories.Interfaces;

namespace JC_ViaBrasil.Services
{
    public class TabelaFipeService : ITabelaFipeService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;
        private readonly ITabelaFipeRepository _repo;

        public TabelaFipeService(IMapper mapper, IBrasilApi brasilApi, ITabelaFipeRepository repo)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
            _repo = repo;
        }
        public async Task<TabelaFipeDTO> BuscarPorCodigoAno(string codigoFipe, int ano)
        {
            var tabelaFipe = await _brasilApi.BuscarPorCodigo(codigoFipe);

            var tabelaDTO = _mapper.Map<ResponseGenerico<List<TabelaFipeDTO>>>(tabelaFipe);

            var retorno = new TabelaFipeDTO();

            retorno = tabelaDTO.DadosRetorno.FirstOrDefault(x => x.anoModelo.Equals(ano));

            return retorno; 
        }

        public async Task<TabelaFipeDTO> BuscarPorPlaca(string placaVeiculo)
        {
            var result = await _repo.GetByPlacaAsync(placaVeiculo);

            return _mapper.Map<TabelaFipeDTO>(result);
        }

        public async Task<TabelaFipeDTO> CreateAsync(TabelaFipeDTO tabelaFipeDTO)
        {
            var tabela = _mapper.Map<TabelaFipe>(tabelaFipeDTO);

            if(tabelaFipeDTO.id.Equals(0)) tabela.id = null;

            var data = await _repo.CreateAsync(tabela);

            return _mapper.Map<TabelaFipeDTO>(data);
        }

        //public Task DeleteAsync(TabelaFipeDTO dto)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TabelaFipeDTO> EditAsync(TabelaFipeDTO dto)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

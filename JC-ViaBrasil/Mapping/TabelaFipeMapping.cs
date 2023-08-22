using AutoMapper;
using JC_ViaBrasil.DTOs;
using JC_ViaBrasil.Models;

namespace JC_ViaBrasil.Mapping
{
    public class TabelaFipeMapping : Profile
    {
        public TabelaFipeMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<TabelaFipeDTO, TabelaFipe>();
            CreateMap<TabelaFipe, TabelaFipeDTO>();
        }
    }
}

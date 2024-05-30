using AutoMapper;
using BrasilApiServices.Models.DTOs;
using BrasilApiServices.Models;

namespace BrasilApiServices.Mapping
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}

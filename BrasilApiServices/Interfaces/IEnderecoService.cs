using BrasilApiServices.Models.DTOs;

namespace BrasilApiServices.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}

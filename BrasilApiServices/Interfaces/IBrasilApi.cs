﻿using BrasilApiServices.Models.DTOs;
using BrasilApiServices.Models;

namespace BrasilApiServices.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}

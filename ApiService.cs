using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<string>> GetModelosCarrosCombustao()
    {
        return await _httpClient.GetFromJsonAsync<List<string>>("CarroCombustao");
    }

    public async Task<bool> CriarCarro(CarroCombustao carro)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("CarroCombustao", carro);

            return response.IsSuccessStatusCode;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

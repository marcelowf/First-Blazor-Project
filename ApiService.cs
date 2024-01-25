using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:5297/");
    }

    public async Task<List<string>> GetCarroCombustao()
    {
        return await _httpClient.GetFromJsonAsync<List<string>>("CarroCombustao");
    }

    public async Task<bool> PostCarroCombustao(BaseJsonCarroCombustao carro)
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

    public async Task<bool> DeleteCarroCombustao(string placa)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"CarroCombustao/{placa}");

            return response.IsSuccessStatusCode;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> PutCarroCombustao(string placa, BaseJsonCarroCombustao carroAtualizado)
    {
        try
        {
            var response = await _httpClient.PutAsJsonAsync($"CarroCombustao/{placa}", carroAtualizado);

            return response.IsSuccessStatusCode;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

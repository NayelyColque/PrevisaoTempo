using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using PrevisaoTempo.Models;

namespace PrevisaoTempo.Services
{
    public class CidadeService
    {
        private HttpClient httpClient;
        private Cidade cidade;
        private string NomeCidade;
        private ObservableCollection<Cidade>? cidades;
        private JsonSerializerOptions? jsonSerializerOptions;

        public CidadeService()
        {
            this.httpClient = new();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<ObservableCollection<Cidade>?> FetchCidades(string NomeCidade)
        {
            Uri uri = new($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{NomeCidade}");
            try
            {
                HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    cidades = JsonSerializer.Deserialize<ObservableCollection<Cidade>>(json, jsonSerializerOptions);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cidades;
        }
    }
}

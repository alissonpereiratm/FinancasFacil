﻿

namespace FinancasFacil
{
    public  class BaseClient
    {
        static readonly HttpClient _client = new HttpClient();
        string _baseUrl = "https://d83stmbm-7029.brs.devtunnels.ms/";
                           
        public async Task<HttpResponseMessage> GetShare(string shareSymbol) 
        {
            string end = _baseUrl  + "Share/" + shareSymbol;    
            var response = await _client.GetAsync(end);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao buscar informações da ação");
            }
            return response;        
        }

        public async Task<HttpResponseMessage> GetShare(object simboloAcao)
        {
            throw new NotImplementedException();
        }
    }
}

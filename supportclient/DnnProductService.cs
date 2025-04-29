using Newtonsoft.Json;
using supportclient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace supportclient
{
    public class DnnProductService
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;

        public DnnProductService(HttpClient http, string apiKey)
        {
            _http = http;
            _apiKey = apiKey;
        }

        public async Task<List<ProductDTO>> GetAllAsync(int page = 1, int pageSize = 100)
        {
            var url = $"DesktopModules/Hotcakes/API/rest/v1/products?key={_apiKey}&page={page}&pageSize={pageSize}";
            System.Diagnostics.Debug.WriteLine("Hívott URL: " + _http.BaseAddress + url);

            var resp = await _http.GetAsync(url);
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ProductListResponse>(json);
            return result.Content.Products;
        }
    }

}

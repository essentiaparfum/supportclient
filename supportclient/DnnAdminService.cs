using Newtonsoft.Json;
using System.Text;

public class DnnAdminService
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public DnnAdminService(HttpClient http, string apiKey)
    {
        _http = http;
        _apiKey = apiKey;
    }

    public async Task SaveRelatedAsync(string productId, List<string> relatedIds)
    {
        var dto = new RelatedProductDto
        {
            ProductId = productId,
            RelatedProducts = relatedIds
        };

        var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");

        var url = $"DesktopModules/Hotcakes/API/rest/v1/productrelationships?key={_apiKey}";
        var resp = await _http.PostAsync(url, content);
        resp.EnsureSuccessStatusCode();
    }
}

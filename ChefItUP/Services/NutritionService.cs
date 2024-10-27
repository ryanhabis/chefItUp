namespace ChefItUP.Services;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

public class NutritionService
{
    private readonly HttpClient _httpClient;
    private readonly string _appId = "d0b9e2d4"; // replace with your Edamam App ID
    private readonly string _appKey = "3b3a26bac0e5081c46eab4c37427bc46"; // replace with your Edamam API Key

    public NutritionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<NutritionResponse> GetNutritionDataAsync(string ingredient)
    {
        var url = $"https://api.edamam.com/api/nutrition-data?app_id={_appId}&app_key={_appKey}&ingr={HttpUtility.UrlEncode(ingredient)}";
        return await _httpClient.GetFromJsonAsync<NutritionResponse>(url);
    }
}
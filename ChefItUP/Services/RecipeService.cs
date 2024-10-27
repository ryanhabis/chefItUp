using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChefItUP.Services;

public class RecipeService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "7555f3a8a8b14266a1fe8ee7d7381c85";

    public RecipeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<RecipeResponse.Recipe>> GetRecipesAsync(string query = "Pasta")
    {
        var response = await _httpClient.GetFromJsonAsync<RecipeResponse>(
            $"https://api.spoonacular.com/recipes/complexSearch?query={query}&apiKey={_apiKey}"
        );
        return response?.Results;
    }
}
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ChefItUP.Services;

public class RecipeService
{
    private readonly HttpClient httpClient;
    private readonly string apiKey = "7555f3a8a8b14266a1fe8ee7d7381c85";

    public RecipeService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<RecipeResponse.Recipe>> GetRecipesAsync(string query = "pasta")
    {
        var response = await httpClient.GetFromJsonAsync<RecipeResponse>(
            $"https://api.spoonacular.com/recipes/complexSearch?query={query}&apiKey={apiKey}"
        );
        return response?.Results;
    }
}
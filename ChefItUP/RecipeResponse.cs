namespace ChefItUP;

public class RecipeResponse
{
    public List<Recipe> Results { get; set; }
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }


}
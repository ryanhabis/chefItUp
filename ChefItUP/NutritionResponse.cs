namespace ChefItUP;

public class NutritionResponse
{
    public double Calories { get; set; }
    public TotalNutrients TotalNutrients { get; set; }
}

public class TotalNutrients
{
    public Nutrient ENERC_KCAL { get; set; }
    public Nutrient FAT { get; set; }
    public Nutrient CHOCDF { get; set; }
    public Nutrient PROCNT { get; set; }
}

public class Nutrient
{
    public string Label { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
}

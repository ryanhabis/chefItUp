# Chef It Up 🍴

Welcome to **Chef It Up**, a Blazor-based web application that makes meal planning a breeze. This app integrates two well-documented APIs to bring together a recipe finder and a nutrition tracker, enabling users to discover delicious recipes while keeping their nutritional goals in check.

## Features 🚀

1. **Recipe Finder**:  
   Search for recipes based on ingredients, cuisine, or dietary preferences.
   
2. **Nutrition Tracker**:  
   Get detailed nutritional information for recipes, including calorie count, macronutrient breakdown, and more.
   
3. **Blazor-Powered Interface**:  
   Enjoy a responsive, modern, and intuitive user experience with Blazor.

4. **Data Persistence**:  
   Save your favourite recipes and track your nutrition over time.

## Technologies Used 🛠️

- **Blazor (ASP.NET)**: For building the frontend and interactive user experience.
- **ASP.NET Razor**: For CRUD operations and server-side rendering.
- **APIs**:  
  - A recipe API to fetch recipes.  
  - A nutrition API to analyze nutritional content.

## Getting Started 🏁

### Prerequisites
- .NET 6 SDK or higher
- Visual Studio 2022
- Internet connection for API requests

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/ryanhabis/chefItUp.git
   ```
2. Open the solution file (`ChefItUp.sln`) in Visual Studio.
3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

### API Keys
Add your API keys for the Recipe Finder and Nutrition Tracker APIs in the `appsettings.json` file:
```json
{
  "RecipeApiKey": "YOUR_RECIPE_API_KEY",
  "NutritionApiKey": "YOUR_NUTRITION_API_KEY"
}
```

## Usage 🥗

1. **Search Recipes**: Enter ingredients or dietary preferences in the search bar to find recipes.
2. **View Nutrition**: Select a recipe to view its nutritional breakdown.
3. **Save Favourites**: Click the "Save" button to keep track of recipes you love.

## Project Structure 📂

- **/Pages**: Contains Blazor pages for the app's frontend.
- **/Data**: Handles data fetching and API integrations.
- **/Models**: Defines the structure of recipe and nutrition data.
- **/wwwroot**: Static files, including CSS and JS.

## Screenshots 📸
### Home Page
The Home Page welcomes users to Chef It Up with a simple interface, encouraging them to explore recipes and nutritional details.

![chefitup home](https://github.com/user-attachments/assets/1a26092b-baf6-41f9-baad-deec820d9922)

### Recipe Search
Users can search for recipes based on ingredients or dish names. The results include visually appealing images of recipes.

![chefitup Recipe](https://github.com/user-attachments/assets/75173fd0-7418-45be-b5fe-dcd99057c56d)

---

### Nutrition Information

Get detailed nutritional breakdowns of specific ingredients or recipes, including calories, protein, carbs, and fat content.

![chefitup Nutrition](https://github.com/user-attachments/assets/b33eb8c6-1de5-4e8e-97b2-ae6486e3acf4)

---

### Recipe Search with Nutrition Info

Discover recipes that align with your dietary needs, and explore their nutritional profiles in-depth.
Click the image you want to see there nutritional value and scroll to the bottomas shown on the image below.

![chefitup Recipe Search with Nutrition Info 1](https://github.com/user-attachments/assets/a4c79d60-4afb-41dd-bef6-d040a2376ec5)
![chefitup Recipe Search with Nutrition Info 2](https://github.com/user-attachments/assets/11e35acc-f83e-43f2-9ace-72eb36af17eb)

## Contributions 🤝

We welcome contributions! Feel free to:
- Submit pull requests for bug fixes or new features.
- Open issues for feedback or bug reports.

## Contact 📧

For queries or support, please reach out via [GitHub Issues](https://github.com/ryanhabis/chefItUp/issues).

using System.Collections.ObjectModel;

namespace assignment_2425;

public partial class RecipeListPage : ContentPage
{
    public class Recipe
    {
        public string? Name { get; set; }
        public string? Ingredients { get; set; }
        public string? Steps { get; set; }
    }


        private ObservableCollection<Recipe> recipeList = new ObservableCollection<Recipe>();

        public RecipeListPage()
        {
            InitializeComponent();
            recipesCollectionView.ItemsSource = recipeList;
        }

        private async void OnAddRecipeClicked(object sender, EventArgs e)
        {
            string? name= recipeNameEntry.Text?.Trim();
            string?ingredients = ingredientsEditor.Text?.Trim();
            string?steps = stepsEditor.Text?.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ingredients) || string.IsNullOrEmpty(steps))
            {
                await DisplayAlert("Missing Info", "Please fill in all fields.", "OK");
                return;
            }

            var newRecipe = new Recipe
            {
                Name = name,
                Ingredients = ingredients,
                Steps = steps
            };

            recipeList.Add(newRecipe);


            recipeNameEntry.Text = "";
            ingredientsEditor.Text = "";
            stepsEditor.Text = "";

            await DisplayAlert("Success", $"Recipe '{name}' added!", "OK");
        }
    
}

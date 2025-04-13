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
        await Shell.Current.GoToAsync(nameof(AddRecipe));
    }

}
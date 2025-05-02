using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using StudentBudgetApp;
namespace StudentBudgetApp;



public partial class ExpenseListPage : ContentPage
{
    public class Recipe
    {
        public string? Name { get; set; }
        public string? Ingredients { get; set; }
        public string? Steps { get; set; }
    }


    private ObservableCollection<Recipe> recipeList = new ObservableCollection<Recipe>();

    public ExpenseListPage()
    {
        InitializeComponent();
        MessagingCenter.Subscribe<AddRecipe, Recipe>(this, "RecipeAdded", (sender, recipe) =>
        {
            recipeList.Add(recipe);
            RecipeListView.ItemsSource = recipeList;
        });
      
    }

    private async void OnAddRecipeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddRecipe));
    }

}
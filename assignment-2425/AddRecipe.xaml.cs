using System.Text.Json;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace assignment_2425;

public partial class AddRecipe : ContentPage
{
    public AddRecipe()
    {
        InitializeComponent();
    }

    private async void OnAddRecipeClicked(object sender, EventArgs e)
    {
        var newRecipe = new Recipe
        {
            Title = recipeNameEntry.Text,
            Description = descriptionEditor.Text,
            Ingredients = ingredientsEditor.Text,
            Instructions = stepsEditor.Text
        };

        var json = Preferences.Default.Get("SavedRecipes", string.Empty);
        var list = string.IsNullOrWhiteSpace(json)
            ? new List<Recipe>()
            : JsonSerializer.Deserialize<List<Recipe>>(json);

        list.Add(newRecipe);

        var newJson = JsonSerializer.Serialize(list);
        Preferences.Default.Set("SavedRecipes", newJson);

        await DisplayAlert("Saved", "Your recipe has been saved!", "OK");
        await Shell.Current.GoToAsync(".."); // Navigate back
    }
}

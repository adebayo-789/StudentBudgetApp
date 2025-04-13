using System.Text.Json;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using assignment_2425;

namespace assignment_2425;

public partial class AddRecipe : ContentPage
{
    public AddRecipe()
    {
        InitializeComponent();
    }

    private async void OnAddRecipeClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(recipeNameEntry.Text))
        {
            await DisplayAlert("Missing Info", "Please enter a recipe title.", "OK");
            return;
        }

        
        var newRecipe = new Recipe
        {
            Title = recipeNameEntry.Text,
            Description = descriptionEditor.Text,
            Ingredients = ingredientsEditor.Text,
            Instructions = stepsEditor.Text
        };

        await Shell.Current.GoToAsync("..", true); // Navigate back
        MessagingCenter.Send(this, "RecipeAdded", newRecipe); // Send the recipe to whoever is listening
    }
}

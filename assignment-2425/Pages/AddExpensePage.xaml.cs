using StudentBudgetApp.ViewModels;
using StudentBudgetApp.Models;

namespace StudentBudgetApp.Pages;

public partial class AddExpensePage : ContentPage
{
    private readonly BudgetViewModel _viewModel;

    public AddExpensePage(BudgetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
    }
    private  async void OnAddClicked(object sender, EventArgs e)
    {
        string name = DescriptionEntry.Text;
        string category = CategoryPicker.SelectedItem?.ToString() ?? "General";

        if (!string.IsNullOrWhiteSpace(DescriptionEntry.Text) &&
            decimal.TryParse(AmountEntry.Text, out var amount))
        {
            _viewModel.AddExpense(DescriptionEntry.Text, amount, category);
            

            DescriptionEntry.Text = string.Empty;
            AmountEntry.Text = string.Empty;
            CategoryPicker.SelectedIndex = -1;


            await  DisplayAlert("Added", "Expense added successfully.", "OK");
        }
        else
        {
             await DisplayAlert("Error", "Please enter valid values.", "OK");
            
        }
        await Navigation.PushAsync(new AddExpensePage(_viewModel));

    }

}
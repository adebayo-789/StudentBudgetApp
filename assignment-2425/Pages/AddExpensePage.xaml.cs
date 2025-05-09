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
    private void OnAddClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(DescriptionEntry.Text) &&
            decimal.TryParse(AmountEntry.Text, out var amount))
        {
            _viewModel.AddExpense(new Expense
            {
                Name = DescriptionEntry.Text,
                Amount = amount
            });

            DescriptionEntry.Text = string.Empty;
            AmountEntry.Text = string.Empty;

            DisplayAlert("Added", "Expense added successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "Please enter valid values.", "OK");
        }
    }

}
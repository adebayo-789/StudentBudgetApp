using System;
using StudentBudgetApp.ViewModels;


namespace StudentBudgetApp.Pages;

public partial class DashboardPage : ContentPage

{
    private readonly BudgetViewModel _viewModel;
    public DashboardPage(BudgetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private void OnSetIncomeClicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(IncomeEntry.Text, out var income))
        {
            _viewModel.TotalIncome = income;
            DisplayAlert("Updated", "Total income set successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "Please enter a valid number.", "OK");
        }
    }

}

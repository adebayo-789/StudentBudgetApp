using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using StudentBudgetApp.ViewModels;

public partial class ExpenseListPage : ContentPage
{
    private readonly BudgetViewModel _viewModel;

    public ExpenseListPage(BudgetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}
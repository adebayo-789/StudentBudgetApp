using StudentBudgetApp.ViewModels;
using StudentBudgetApp.Models;

namespace StudentBudgetApp.Pages;

public partial class ExpenseListPage : ContentPage
{
    private readonly BudgetViewModel _viewModel;

    public ExpenseListPage(BudgetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage(_viewModel));
    }
}
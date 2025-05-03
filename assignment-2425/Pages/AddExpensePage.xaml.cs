using StudentBudgetApp.ViewModels;

namespace StudentBudgetApp.Pages;

public partial class AddExpensePage : ContentPage
{
    private readonly BudgetViewModel _viewModel;

    public AddExpensePage(BudgetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
    }

   
}
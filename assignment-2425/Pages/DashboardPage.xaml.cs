using System;
using StudentBudgetApp.ViewModels;

namespace StudentBudgetApp.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage(BudgetViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}

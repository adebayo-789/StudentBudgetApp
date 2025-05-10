using System;
using StudentBudgetApp.ViewModels;

namespace StudentBudgetApp.Pages;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new BudgetViewModel();
      

    }
}

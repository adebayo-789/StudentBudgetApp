using StudentBudgetApp.Pages;

namespace StudentBudgetApp;

public partial class AppShell : Shell
{
    public AppShell()

    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        Routing.RegisterRoute(nameof(AddExpensePage), typeof(AddExpensePage));
        Routing.RegisterRoute(nameof(ExpenseListPage), typeof(ExpenseListPage));
    }
}

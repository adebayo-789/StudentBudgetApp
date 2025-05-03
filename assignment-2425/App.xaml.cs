using StudentBudgetApp.Pages;

namespace StudentBudgetApp;

public partial class App : Application
{
    public App(ExpenseListPage mainPage)
    {
        InitializeComponent();
        MainPage = new NavigationPage(mainPage);
    }
}
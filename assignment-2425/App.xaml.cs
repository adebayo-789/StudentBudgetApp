using StudentBudgetApp.Pages;
using StudentBudgetApp;

namespace StudentBudgetApp;

public partial class App : Application
{
    public App()
    {
        MainPage = new AppShell();
    }
}
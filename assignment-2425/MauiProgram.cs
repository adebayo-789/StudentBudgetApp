using Microsoft.Extensions.Logging;
using StudentBudgetApp.ViewModels;
using StudentBudgetApp.Pages;


namespace StudentBudgetApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<BudgetViewModel>();

        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<AddExpensePage>();
        builder.Services.AddSingleton<ExpenseListPage>();

        return builder.Build();
    }
}
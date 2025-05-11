using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentBudgetApp.Models;

namespace StudentBudgetApp.ViewModels;

public class BudgetViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Expense> Expenses { get; set; } = new ObservableCollection<Expense>();

    private decimal totalIncome;
    private decimal totalExpenses;
    private decimal remainingBalance;
    public decimal TotalIncome
    {
        get => totalIncome;
        set
        {
            if (totalIncome != value)
            {
                totalIncome = value;
                OnPropertyChanged();
                UpdateRemainingBalance();
            }
        }
    }


    public decimal TotalExpenses
    {
        get => totalExpenses;
        private set
        {
            if (totalExpenses != value)
            {
                totalExpenses = value;
                OnPropertyChanged();
                UpdateRemainingBalance();
            }
        }
    }

    public decimal RemainingBalance
    {
        get => remainingBalance;
        private set
        {
            if (remainingBalance != value)
            {
                remainingBalance = value;
                OnPropertyChanged();
            }
        }
    }

    public void AddExpense(string name, decimal amount)
    {
        var expense = new Expense { Name = name, Amount = amount };
        Expenses.Add(expense);
        TotalExpenses += amount;
    }

    private void UpdateRemainingBalance()
    {
        RemainingBalance = TotalIncome - TotalExpenses;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = "")
    =>  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    
}
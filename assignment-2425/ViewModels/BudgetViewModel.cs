using System.Collections.ObjectModel;
using System.ComponentModel;
using StudentBudgetApp.Models;

namespace StudentBudgetApp.ViewModels;

public class BudgetViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Expense> Expenses { get; set; } = new();

    private decimal _income;
    public decimal Income
    {
        get => _income;
        set
        {
            if (_income != value)
            {
                _income = value;
                OnPropertyChanged(nameof(Income));
                OnPropertyChanged(nameof(Remaining));
            }
        }
    }

    public decimal Remaining => Income - Expenses.Sum(e => e.Amount);

    public void AddExpense(string description, decimal amount)
    {
        Expenses.Add(new Expense { Description = description, Amount = amount });
        OnPropertyChanged(nameof(Remaining));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
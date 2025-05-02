using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;


using StudentBudgetApp;
using StudentBudgetApp.ViewModels;



namespace assignment_2425.ViewModels
{
    public class Expense
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }

    public class BudgetViewModel : INotifyPropertyChanged
    {
        private decimal income;

        public decimal Income
        {
            get => income;
            set
            {
                if (income != value)
                {
                    income = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(RemainingBalance));
                }
            }
        }

        public ObservableCollection<Expense> Expenses { get; set; } = new();

        public decimal RemainingBalance => Income - Expenses.Sum(e => e.Amount);

        public void AddExpense(string name, decimal amount)
        {
            Expenses.Add(new Expense { Name = name, Amount = amount });
            OnPropertyChanged(nameof(RemainingBalance));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
namespace StudentBudgetApp
{
    public partial class DashboardPage : ContentPage
    {
        

        public DashboardPage()
        {
            InitializeComponent();
        }

        private async void  OnMyRecipiesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AddExpensePage));

            SemanticScreenReader.Announce(RecipesBtn.Text);
        }


    }

}

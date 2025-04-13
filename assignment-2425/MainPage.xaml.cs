namespace assignment_2425
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void  OnMyRecipiesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(RecipeListPage));

            SemanticScreenReader.Announce(RecipesBtn.Text);
        }


    }

}

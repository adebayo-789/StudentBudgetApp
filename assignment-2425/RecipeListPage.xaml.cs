namespace assignment_2425;

public partial class RecipeListPage : ContentPage
{
	public RecipeListPage()
	{
		InitializeComponent();
		
			Content = new VerticalStackLayout
			{
				Children = {
					new Label { HorizontalOptions = LayoutOptions.Center, 
								VerticalOptions = LayoutOptions.Center,
								Text = "Welcome to .NET MAUI!"
					}
				}
			};
		
	}
}
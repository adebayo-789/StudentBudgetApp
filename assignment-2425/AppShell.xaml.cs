﻿namespace assignment_2425
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute(nameof(RecipeListPage), typeof(RecipeListPage));
        }
    }
}

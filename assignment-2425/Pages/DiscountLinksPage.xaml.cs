using Microsoft.Maui.Controls;
using System;

namespace StudentBudgetApp.Pages
{
    public partial class DiscountLinksPage : ContentPage
    {
        public DiscountLinksPage()
        {
            InitializeComponent();
        }

        private async void OnUniDaysClicked(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.myunidays.com");
        }

        private async void OnStudentBeansClicked(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.studentbeans.com");
        }

        private async void OnTotumClicked(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.totum.com");
        }

        private async void OnSaveTheStudentClicked(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.savethestudent.org");
        }
    }
}
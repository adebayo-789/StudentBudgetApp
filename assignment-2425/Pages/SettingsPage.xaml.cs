using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using StudentBudgetApp;


namespace StudentBudgetApp.Pages;


public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();

       
        fontSizePicker.SelectedIndex = Preferences.Default.Get("FontSizeIndex", 1); // Default to Medium
        darkModeSwitch.IsToggled = Preferences.Default.Get("DarkMode", false);

        ApplyFontSize(fontSizePicker.SelectedIndex);
        ApplyTheme(darkModeSwitch.IsToggled);
    }

    void OnFontSizeChanged(object sender, EventArgs e)
    {
        int selectedIndex = fontSizePicker.SelectedIndex;
        Preferences.Default.Set("FontSizeIndex", selectedIndex);
        ApplyFontSize(selectedIndex);
    }

    void ApplyFontSize(int index)
    {
        double fontSize = index switch
        {
            0 => 12, // Small
            1 => 16, // Medium
            2 => 20, // Large
            _ => 16
        };

        Application.Current.Resources["AppFontSize"] = fontSize;
    }

    void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        bool isDark = e.Value;
        Preferences.Default.Set("DarkMode", isDark);
        ApplyTheme(isDark);
    }

    void ApplyTheme(bool isDark)
    {
        App.Current.UserAppTheme = isDark ? AppTheme.Dark : AppTheme.Light;
    }



}











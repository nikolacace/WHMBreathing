namespace WHMBreathing.UI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSessionStartClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("breathingSession");
        
    }

    private async void SettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }
}


namespace WHMBreathing.UI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSessionStartClicked(object sender, EventArgs e)
    {
        StartBtn.Text = $"Psyche!";

        SemanticScreenReader.Announce(StartBtn.Text);
    }

    private void SettingsClicked(object sender, EventArgs e)
    {
        DisplayAlert("Settings clicked", "settings clicked", "cancel");
    }
}


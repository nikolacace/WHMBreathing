namespace WHMBreathing.UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("breathingSession", typeof(BreathingSession));
		Routing.RegisterRoute("mainMenu", typeof(MainPage));
		Routing.RegisterRoute("settings", typeof(Settings));
	}
}

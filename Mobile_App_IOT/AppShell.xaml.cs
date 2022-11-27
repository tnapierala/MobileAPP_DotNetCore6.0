namespace Mobile_App_IOT;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CallTranslator), typeof(CallTranslator));
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));
	}
}

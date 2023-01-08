namespace Mobile_App_IOT;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CallTranslator), typeof(CallTranslator));
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));
		Routing.RegisterRoute(nameof(TipCalc), typeof(TipCalc));
		Routing.RegisterRoute(nameof(TipCalc2), typeof(TipCalc2));
		Routing.RegisterRoute(nameof(StandardTipCalc), typeof(StandardTipCalc));
    }
}

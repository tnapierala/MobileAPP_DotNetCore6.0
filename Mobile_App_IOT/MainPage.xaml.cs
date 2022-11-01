namespace Mobile_App_IOT;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time \nI catch U on clicked button XD";
		else
			CounterBtn.Text = $" I catch U on clicked button a {count} times XD";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


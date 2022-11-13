namespace Mobile_App_IOT;

public partial class MainPage1 : ContentPage
{
	int count1 = 0;

	public MainPage1()
	{
		InitializeComponent();
	}

	private void OnCounterClicked1(object sender, EventArgs e)
	{
		count1++;

		if (count1 == 1)
			CounterBtn1.Text = $"Clicked {count1} time \nI catch U on clicked button XD";
		else
			CounterBtn1.Text = $" I catch U on clicked button a {count1} times XD";

		SemanticScreenReader.Announce(CounterBtn1.Text);
	}
}


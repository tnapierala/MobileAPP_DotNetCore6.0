using Color = Microsoft.Maui.Graphics.Color;

namespace Mobile_App_IOT;

public partial class MainPage : ContentPage
{
    private Color buttonColorText = Colors.White;
    public MainPage()
    {
        InitializeComponent();
        OnDark();
    }
    //First Build App 
    int count1 = 0;

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count1++;

        if (count1 == 1)
            CounterBtn.Text = $"Clicked {count1} time \nI catch U on clicked button XD";
        else
            CounterBtn.Text = $" I catch U on clicked button a {count1} times XD";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    void OnDark()
    {
        Resources["buttonColorText"] = buttonColorText;
    }

    //Routing
    private async void ButtonCallTranslator(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CallTranslator));
    }

    private async void ButtonViewLogin(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private async void ButtonNotePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NotePage));
    }

    private async void ButtonTipCalc(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TipCalc));
    }
    
    private async void ButtonTipCalc2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TipCalc2));
    }
    private async void ButtonStandardTipCalc(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StandardTipCalc));
    }
    
}


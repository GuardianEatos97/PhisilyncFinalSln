namespace PhisilyncFinal.Tabs;

public partial class SignUpPageAC : ContentPage
{
	public SignUpPageAC()
	{
		InitializeComponent();
        Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AthleteDash");

        
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
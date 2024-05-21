using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class SignUpPageAC : ContentPage
{
	public SignUpPageAC()
	{
		InitializeComponent();
        Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AthleteDash");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
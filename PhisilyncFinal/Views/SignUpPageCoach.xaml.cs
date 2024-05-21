using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class SignUpPageCoach : ContentPage
{
	public SignUpPageCoach()
	{
		InitializeComponent();
        Routing.RegisterRoute("CoachDashboard", typeof(CoachDashboard));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CoachDashboard");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
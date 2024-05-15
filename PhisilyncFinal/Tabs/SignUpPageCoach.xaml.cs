namespace PhisilyncFinal.Tabs;

public partial class SignUpPageCoach : ContentPage
{
	public SignUpPageCoach()
	{
		InitializeComponent();
        Routing.RegisterRoute("CoachDashboard", typeof(CoachDashboard));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CoachDashboard");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
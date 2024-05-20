namespace PhisilyncFinal.Views;
public partial class SignUpPageSP : ContentPage
{
	public SignUpPageSP()
	{
		InitializeComponent();
        Routing.RegisterRoute("ServiceProviderDashboard", typeof(ServiceProviderDashboard));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ServiceProviderDashboard");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
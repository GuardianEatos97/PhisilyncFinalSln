namespace PhisilyncFinal.Views;
public partial class TellUsPage : ContentPage
{
    public TellUsPage()
    {
        InitializeComponent();
        Routing.RegisterRoute("SignUpPageAC", typeof(SignUpPageAC));
        Routing.RegisterRoute("SignUpPageSP", typeof(SignUpPageSP));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
        Routing.RegisterRoute("SignUpPageCoach", typeof(SignUpPageCoach));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SignUpPageAC");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SignUpPageSP");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SignUpPageCoach");
    }
}

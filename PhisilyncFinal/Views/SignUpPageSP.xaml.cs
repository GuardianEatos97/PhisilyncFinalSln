namespace PhisilyncFinal.Views;
public partial class SignUpPageSP : ContentPage
{

	public SignUpPageSP()
	{
		InitializeComponent();
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SPDash");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
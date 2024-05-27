namespace PhisilyncFinal.Views;

public partial class GlossaryDetailsPage : ContentPage
{
	public GlossaryDetailsPage()
	{
		InitializeComponent();
	}

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("GlossaryView");
    }
}
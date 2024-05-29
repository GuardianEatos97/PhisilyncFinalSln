namespace PhisilyncFinal.Views;

public partial class InjuryDetailsPage : ContentPage
{
	public InjuryDetailsPage()
	{
		InitializeComponent();
	}

    private async void GlossaryBtn_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("GlossaryView");
    }

    private async void TestAndReleaseBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TestAndReleasePage");
    }

   
}
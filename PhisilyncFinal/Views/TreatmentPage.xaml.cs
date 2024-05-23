namespace PhisilyncFinal.Views;

public partial class TreatmentPage : ContentPage
{
	public TreatmentPage()
	{
		InitializeComponent();
    }

    private async void LynoBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LynoPage");
    }

    private async void MassageBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MassagePage");
    }

    private async void TapingBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Taping");
    }

    private async void StretchBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Stretch");
    }

    private async void RomBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ROMPage");
    }
}
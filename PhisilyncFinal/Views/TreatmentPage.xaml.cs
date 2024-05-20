namespace PhisilyncFinal.Views;

public partial class TreatmentPage : ContentPage
{
	public TreatmentPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("LynoTherapyPage", typeof(LynoTherapyPage));
        Routing.RegisterRoute("MassageTherapyPage", typeof(MassageTherapyPage));
        Routing.RegisterRoute("TapingPage", typeof(TapingPage));
        Routing.RegisterRoute("StretchesAndExercisePage", typeof(StretchesAndExercisePage));
        Routing.RegisterRoute("RangeOfMovementPage", typeof(RangeOfMovementPage));
    }

    private async void LynoBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LynoTherapyPage");
    }

    private async void MassageBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MassageTherapyPage");
    }

    private async void TapingBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TapingPage");
    }

    private async void StretchBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StretchesAndExercisePage");
    }

    private async void RomBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RangeOfMovementPage");
    }
}
namespace PhisilyncFinal.Views;

public partial class FasciaSkeleton : ContentPage
{
	public FasciaSkeleton()
	{
		InitializeComponent();
	}

    private async void UpperBody_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("UpperBodyWeb");
    }

    private async void LowerBody_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LowerBodyWeb");
    }

    private async void Neck_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NeckWebView");
    }
}
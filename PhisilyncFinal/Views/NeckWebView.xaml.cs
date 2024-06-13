namespace PhisilyncFinal.Views;

public partial class NeckWebView : ContentPage
{
	public NeckWebView()
	{
		InitializeComponent();
        NeckWeb.Source = @"https://viewer.jig.space/?jig=4GaYRkMG&shad=1&step=1&sbox=1&autoload=1&autoplay=0%22";
    }
}
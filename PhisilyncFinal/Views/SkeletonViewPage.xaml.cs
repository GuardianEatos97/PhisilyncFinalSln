namespace PhisilyncFinal.Views;

public partial class SkeletonViewPage : ContentPage
{
	public SkeletonViewPage()
    {
        InitializeComponent();

        WebviewSkeleton.Source = @"https://viewer.jig.space/?jig=wGbN1X5G&shad=1&step=1&sbox=1&autoload=1&autoplay=0";
        //string source = "https://viewer.jig.space/?jig=wGbN1X5G&shad=1&step=1&sbox=1&autoload=1&autoplay=0";
        //var wv = new WebView();
        //content.Content = wv;
        //wv.Source = source;
        //wv.Reload();
    }

    //WebView webvView = new WebView
    //{
    //    Source = "https://learn.microsoft.com/dotnet/maui"
    //};
}
namespace PhisilyncFinal.Tabs;

public partial class PrivacyPolicy : ContentPage
{
	public PrivacyPolicy()
	{
		InitializeComponent();
	}

    private async void FbBtn_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.facebook.com/");
    }

    private async void InstaBtn_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.instagram.com/phisilync?igsh=MTVheHQ2ZWUxczliYQ==");
    }

    private async void XBtn_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://x.com/Phisilync?t=faQ29iNN7H7jQyTghd9UpQ&s=09");
    }

    private async void TikTokBtn_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.tiktok.com/@phisilync?lang=en");
    }

    private async void LinkedinBtn_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.linkedin.com/in/phisilync-pty-ltd-704795309?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app");
    }

}
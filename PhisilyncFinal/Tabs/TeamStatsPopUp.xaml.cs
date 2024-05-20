using CommunityToolkit.Maui.Views;

namespace PhisilyncFinal.Tabs;

public partial class TeamStatsPopUp : Popup
{
	public TeamStatsPopUp()
	{
		InitializeComponent();
	}

    private void Done_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}
using CommunityToolkit.Maui.Views;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class CoachDashboard : ContentPage
{
	//public EventCollection CoachEvents { get; set; }
	public CoachDashboard(CoachDashVM coachDashVM)
	{
		InitializeComponent();
        BindingContext = coachDashVM;

    }

    private void PopUpClicked(object sender, EventArgs e)
    {
        if (BindingContext is CoachDashVM viewModel)
        {
            viewModel.PopUpClicked(sender, e);
        }
    }




}
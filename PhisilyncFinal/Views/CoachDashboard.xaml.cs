using CommunityToolkit.Maui.Views;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class CoachDashboard : ContentPage

{
	public CoachDashboard(CoachDashVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
        BindingContext = new InjuryLibraryViewModel();

    }

    private void PopUpClicked(object sender, EventArgs e)
    {
        if (BindingContext is CoachDashVM viewModel)
        {
            viewModel.PopUpClicked(sender, e);
        }
    }




}
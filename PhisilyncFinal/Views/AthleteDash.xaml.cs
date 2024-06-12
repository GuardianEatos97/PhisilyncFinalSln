using PhisilyncFinal.ViewModels;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.Models;
using CommunityToolkit.Mvvm.Input;
using MauiPopup;



namespace PhisilyncFinal.Views;

public partial class AthleteDash : ContentPage
{
    

    public AthleteDash(AthleteDashVM athleteDashVM)
    {
        InitializeComponent();
        BindingContext = athleteDashVM;
        OnAppearing();
    }

    private async void TreatmentProviderBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///TreatmentPage");
    }

    protected void OnAppearing()
    {
        base.OnAppearing();

        var vm = (AthleteDashVM)BindingContext;

        vm.OnAppearing();

        //await athleteDashVM.GetEvents();
    }

    private bool _rotated = false;

    private void MenuButton_Clicked(object sender, EventArgs e)
    {

        ((ImageButton)sender).RotateTo(_rotated ? 0 : -90);

        //fabBtnsContainer.Margin = new Thickness(0, 0, _rotated ? 0 : -100, 50);

        floatButtonContainer.Animate<Thickness>("fab_btns",
            value => // goes from 0 -> 1
            {   // 0.1
                // 0.01,... 0.05,... 0.6,... 0.9,... 1

                int factor = Convert.ToInt32(value * 10); // 1

                var rightMargin =
                    !_rotated
                    ? (factor * 10) - 100  //10 - 100 => -90,    0.2 => 20-100 => -80 ..... 100 - 100 => 0
                    : (factor * 10) * -1; // 10*-1 => -10		20 *-1 => -20, ....... 100 * -1 => -100

                return new Thickness(0, 0, rightMargin, 50);
            },
            newThickness => floatButtonContainer.Margin = newThickness // The parameter come from the previous Func delegate parameter
            , length: 200
            , finished: (_, __) => _rotated = !_rotated);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        
    }
}
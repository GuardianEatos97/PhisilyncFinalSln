using PhisilyncFinal.ViewModels;
using Plugin.Maui.Calendar.Models;
using PhisilyncFinal.Models;
using CommunityToolkit.Mvvm.Input;



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

}
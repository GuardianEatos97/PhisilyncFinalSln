using System.Windows.Input;

namespace PhisilyncFinal.Views;

public partial class EditProfile : ContentPage
{
	public EditProfile()
	{
		InitializeComponent();
		BindingContext = this;
	}

    public ICommand NavigateToProfileDetailsCommand => new Command(() => NavigateToProfileDetails());
    public ICommand NavigateToPaymentsCommand => new Command(() => NavigateToPayments());
    public ICommand NavigateToSettingsCommand => new Command(() => NavigateToSettings());

    private async void NavigateToProfileDetails()
    {
        //await Navigation.PushAsync(new ProfileDetails());
        await Shell.Current.GoToAsync("ProfileDetails");
    }

    private async void NavigateToPayments()
    {
        //await Navigation.PushAsync(new Payment());
        await Shell.Current.GoToAsync("Payment");
    }

    private async void NavigateToSettings()
    {
        //await Navigation.PushAsync(new Settings());
        await Shell.Current.GoToAsync("Settings");
    }
}
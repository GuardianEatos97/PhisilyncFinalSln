using System.Windows.Input;

namespace PhisilyncFinal.Tabs;

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
        await Navigation.PushAsync(new ProfileDetails());
    }

    private async void NavigateToPayments()
    {
        await Navigation.PushAsync(new Payment());
    }

    private async void NavigateToSettings()
    {
        await Navigation.PushAsync(new Settings());
    }
}
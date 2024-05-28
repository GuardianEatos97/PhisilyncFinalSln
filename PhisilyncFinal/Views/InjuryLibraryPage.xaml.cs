 using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Models;
namespace PhisilyncFinal.Views;

public partial class InjuryLibraryPage : ContentPage
{
	public InjuryViewModel viewModel;

    public InjuryLibraryPage(InjuryViewModel vm)
	{
		InitializeComponent();
		viewModel = vm;
        BindingContext = vm;
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var injury = ((ListView)sender).SelectedItem as ProviderInjury;
        if (injury != null)
        {
            var page = new TestAndReleasePage();
            page.BindingContext = injury;
            await Navigation.PushAsync(page);
            
            
        }
    }
}
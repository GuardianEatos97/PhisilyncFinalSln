using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Models;
namespace PhisilyncFinal.Views;

public partial class InjuryPage : ContentPage
{
	public InjuryPage()
	{
		InitializeComponent();
		BindingContext = new InjuryLibraryViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var injury = ((ListView)sender).SelectedItem as InjuryLibrary;
        if (injury != null)
        {
            var page = new InjuryDetailsPage();
            page.BindingContext = injury;
            await Navigation.PushAsync(page);
        }
    }
}
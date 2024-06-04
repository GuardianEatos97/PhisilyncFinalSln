using PhisilyncFinal.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class SelectInjuryPage : ContentPage
{
    InjuryViewModel injuryViewModel;
    public ProviderInjury? _injury;
    public SelectInjuryPage(InjuryViewModel vm)
	{
		InitializeComponent();
        injuryViewModel = vm;
        BindingContext = vm; 
    }
    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
         _injury = ((ListView)sender).SelectedItem as ProviderInjury;
       
        if (_injury != null)
        {
            var page = new SelectedInjuryDetailsPage(_injury);
            page.BindingContext = _injury;
            
            await Shell.Current.Navigation.PushAsync(page);


        }
    }


}
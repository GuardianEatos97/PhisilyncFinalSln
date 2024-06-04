using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace PhisilyncFinal.Views;

public partial class SelectedInjuryDetailsPage : ContentPage
{
    
    public ProviderInjury _injury;
    public SelectedInjuryDetailsPage(ProviderInjury injury)
	{
		InitializeComponent();
        BindingContext = _injury;
        _injury = injury;

    }
    



    
    private async void Button_Clicked(object sender, EventArgs e)
    {  
        //var page = new TestAndReleasePage(_injury);
        
        await Shell.Current.Navigation.PushAsync(new TestAndReleasePage(_injury));
    }
}
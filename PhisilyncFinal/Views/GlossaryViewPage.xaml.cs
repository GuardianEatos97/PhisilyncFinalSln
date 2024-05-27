using PhisilyncFinal.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class GlossaryViewPage : ContentPage
{
    public GlossaryViewPage()
    {
        InitializeComponent();
        BindingContext = new GlossaryViewModel();
    }
    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var word = ((ListView)sender).SelectedItem as Glossary;
        if (word != null)
        {
            var page = new GlossaryDetailsPage();
            page.BindingContext = word;
            await Navigation.PushAsync(page);
        }
    }
}
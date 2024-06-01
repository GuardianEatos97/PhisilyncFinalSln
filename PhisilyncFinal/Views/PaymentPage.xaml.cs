using PhisilyncFinal.Models;

namespace PhisilyncFinal.Views;

public partial class PaymentPage : ContentPage
{
    public PaymentPage()
    {
        InitializeComponent();
    }

    private void ListView_ItemTapped2(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected2(object sender, SelectedItemChangedEventArgs e)
    {
        var payme = ((ListView)sender).SelectedItem as Payments;
        if (payme != null)
        {
            var page = new PaymentDetailsPage();
            page.BindingContext = payme;
            await Navigation.PushAsync(page);
        }
    }
}
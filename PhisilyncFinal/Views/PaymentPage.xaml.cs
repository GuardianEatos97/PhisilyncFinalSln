using PhisilyncFinal.Models;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class PaymentPage : ContentPage
{
    public PaymentPage()
    {
        InitializeComponent();
        BindingContext = new PaymentViewModel();
    }

    private void ListView_ItemTapped2(object sender, ItemTappedEventArgs e)
    {
        ((ListView)sender).SelectedItem = null;
    }

    private async void ListView_ItemSelected2(object sender, SelectedItemChangedEventArgs e)
    {
        var payment = ((ListView)sender).SelectedItem as Payments;
        if (payment != null)
        {
            var page = new PaymentDetailsPage();
            page.BindingContext = payment;
            await Navigation.PushAsync(page);
        }
    }
}
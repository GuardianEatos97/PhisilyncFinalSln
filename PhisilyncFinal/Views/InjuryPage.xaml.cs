using PhisilyncFinal.ViewModels;
namespace PhisilyncFinal.Views;

public partial class InjuryPage : ContentPage
{

	public InjuryPage(InjuryViewModel vm)
	{

		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((InjuryViewModel)BindingContext)?.Initialize();
    }
}

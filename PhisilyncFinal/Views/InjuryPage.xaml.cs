using PhisilyncFinal.ViewModels;
namespace PhisilyncFinal.Views;

public partial class InjuryPage : ContentPage
{

	public InjuryPage(InjuryLibraryViewModel vm)
	{

		InitializeComponent();
		//BindingContext _viewmodel;
		BindingContext = vm;
	}
}
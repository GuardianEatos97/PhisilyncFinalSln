using PhisilyncFinal.ViewModels;
namespace PhisilyncFinal.Views;

public partial class InjuryPage : ContentPage
{
	InjuryLibraryViewModel _viewModel;
	public InjuryPage(InjuryLibraryViewModel vm)
	{
		_viewModel = vm;
		InitializeComponent();
		//BindingContext _viewmodel;
		BindingContext = new InjuryLibraryViewModel();
	}
}
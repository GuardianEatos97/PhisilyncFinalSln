using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class LennyAiAnswerPage : ContentPage
{
	LennyAnswerPageVM _viewmodel;
	public LennyAiAnswerPage(LennyAnswerPageVM vm)
	{
		InitializeComponent();
        _viewmodel = vm;
        BindingContext = _viewmodel;
    }
}
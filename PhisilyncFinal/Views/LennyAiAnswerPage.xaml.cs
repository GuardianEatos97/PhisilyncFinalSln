using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class LennyAiAnswerPage : ContentPage
{
	LennyAnswerPageVM _viewmodel;
	public LennyAiAnswerPage(LennyAnswerPageVM vm)
	{
        _viewmodel = vm;
        InitializeComponent();
        BindingContext = _viewmodel;
    }
}
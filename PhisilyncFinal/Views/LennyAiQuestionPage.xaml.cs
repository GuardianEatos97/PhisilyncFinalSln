using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class LennyAiQuestionPage : ContentPage
{
	LennyQuestionPageVM _viewmodel;
	public LennyAiQuestionPage(LennyQuestionPageVM vm)
	{
		InitializeComponent();
        _viewmodel = vm;
        BindingContext = _viewmodel;

    }
}
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class SignUpPageAC : ContentPage
{
	public SignUpPageAC(SUPageACVM vm)
	{
		InitializeComponent();


		BindingContext = vm;

    }



}
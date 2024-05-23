using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class SignUpPageAC : ContentPage
{


    public SignUpACVM _viewModel;
    

    public SignUpPageAC(SignUpACVM vm)
	{
		InitializeComponent();
        _viewModel=vm;
        BindingContext = vm;
    }

    
}
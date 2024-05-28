using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class SignUpPageSP : ContentPage
{

    public SignUpPageSP(SignUpSPVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }


}
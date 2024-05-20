using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;
public partial class SignUpPageCoach : ContentPage
{
	public SignUpPageCoach(SUPageCVM vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }


}
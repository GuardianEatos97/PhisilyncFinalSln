using System.Windows.Input;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class EditProfile : ContentPage
{
	public EditProfile(EditProfileVM editProfileVM)
	{
		InitializeComponent();
		BindingContext = editProfileVM;
	}

}
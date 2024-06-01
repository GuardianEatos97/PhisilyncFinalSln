using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using System.ComponentModel;

namespace PhisilyncFinal.Views;

public partial class ProfileDetails 
{

    public ProfileDetails(ProfileDetailsVM profileDetailsVM)
	{
		InitializeComponent();
        BindingContext = profileDetailsVM;
    }
    
}
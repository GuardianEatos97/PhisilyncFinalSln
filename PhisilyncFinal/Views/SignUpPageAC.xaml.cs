using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;

namespace PhisilyncFinal.Views;

public partial class SignUpPageAC : ContentPage
{
    //public LocalDb _database;

    //private User _currentUser;

    //public User CurrentUser
    //{
    //    get { return _currentUser; }
    //    set { _currentUser = value; OnPropertyChanged(); }
    //}

    //private TreatmentDashboard _userDash;

    //public TreatmentDashboard UserDash
    //{
    //    get { return _userDash; }
    //    set { _userDash = value; OnPropertyChanged(); }
    //}


    public SignUpPageAC(SignUpACVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
        //_database = new();
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    CurrentUser = _database.GetUserByEmail(emailEntry.Text);
    //    UserDash = new();

    //    if (CurrentUser == null)
    //    {
    //        CurrentUser = new()
    //        {
    //            userName = nameEntry.Text,
    //            userSurname = surnameEntry.Text,
    //            userEmail = emailEntry.Text,
    //            userPassword = passwordEntry.Text,
    //            userType = 1
    //        };

    //        try
    //        {
    //            _database.SaveUser(CurrentUser);
    //            _database.SaveDash(UserDash,CurrentUser);
    //            await Shell.Current.GoToAsync("AthleteDash");
    //        }
    //        catch (Exception ex)
    //        {
    //            await DisplayAlert("Profile already exists", ex.Message, "Please login");
    //        }
    //    }
    //}

    //private async void Button_Clicked_1(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync("LogInPage");
    //}
}
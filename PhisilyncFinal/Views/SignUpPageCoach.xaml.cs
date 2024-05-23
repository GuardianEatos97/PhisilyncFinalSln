using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;

namespace PhisilyncFinal.Views;
public partial class SignUpPageCoach : ContentPage
{
    public LocalDb _database;

    private User _currentUser;

    public User CurrentUser
    {
        get { return _currentUser; }
        set { _currentUser = value; OnPropertyChanged(); }
    }
    public SignUpPageCoach()
	{
        InitializeComponent();
        _database = new();
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        CurrentUser = new()
        {
            userName = nameEntry.Text,
            userSurname = surnameEntry.Text,
            userEmail = emailEntry.Text,
            userPassword = passwordEntry.Text,
        };

        try
        {
            _database.SaveUser(CurrentUser);
            await Shell.Current.GoToAsync("CoachDash");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Profile already exists", ex.Message, "Please login");
        }

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
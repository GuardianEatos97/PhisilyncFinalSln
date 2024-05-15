using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using SQLite;
namespace PhisilyncFinal.Tabs;

public partial class SignUpPageAC : ContentPage
{
    public LocalDb _database;

    private User _currentUser;

    public User CurrentUser
    {
        get { return _currentUser; }
        set { _currentUser = value;
            OnPropertyChanged();
        }
    }

    public SignUpPageAC()
	{
        
        Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
        Routing.RegisterRoute("LogInPage", typeof(LogInPage));
        BindingContext = this;
        _database = new();
        InitializeComponent();
        
    }

    private async void CreateAccountButton(object sender, EventArgs e)
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
            //_database.InsertCurrentUser);
            _database.SaveUser(CurrentUser);
            await Shell.Current.GoToAsync("AthleteDash");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LogInPage");
    }
}
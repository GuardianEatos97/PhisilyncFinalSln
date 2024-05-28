using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System.ComponentModel;

namespace PhisilyncFinal.Views;

public partial class ProfileDetails : ContentPage, INotifyPropertyChanged
{
    private LocalDb _database;

    private User _currentUser;
    public User CurrentUser
    {
        get { return _currentUser; }
        set { _currentUser = value; OnPropertyChanged(); }
    }
    public ProfileDetails()
	{
		InitializeComponent();
        CurrentUser = LoadUser();
    }
    private User LoadUser()
    {
        if (_database._dbConnection.Table<User>().Count() != 0)
        {
            return _database.GetUserByID(1);
        }
        else
        {
            return new User();
        }
    }
}
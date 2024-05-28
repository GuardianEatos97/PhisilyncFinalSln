using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.Views;

namespace PhisilyncFinal
{
    public partial class App : Application
    {
        private LocalDb _database;
        public App()
        {
            InitializeComponent();
            _database = new LocalDb();
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            //bool isUsers = _database._dbConnection.Table<User>().Count() != 0;
            //var userType = _database.GetUser(1).userType;

            //if (isUsers & _database.GetUser(1).userType == 2)
            //{
            //    await Shell.Current.GoToAsync("coachDash");
            //}
            //if (isUsers & _database.GetUser(1).userType == 1)
            //{
            //    await Shell.Current.GoToAsync("athleteDash");
            //}
            //else
            //{
            //    await Shell.Current.GoToAsync("TellUs");
            //}
            //await Shell.Current.GoToAsync("TellUs");
            //base.OnStart();

            if (_database._dbConnection.Table<User>().Count() != 0 && _database.GetUser(1).userType == 1)
            {
                await Shell.Current.GoToAsync("athleteDash");
            }
            else if (_database._dbConnection.Table<User>().Count() != 0 && _database.GetUser(1).userType == 2)
            {
                await Shell.Current.GoToAsync("coachDash");
            }
            else
            {
                await Shell.Current.GoToAsync("TellUs");
            }
            base.OnStart();
        }
    }
}

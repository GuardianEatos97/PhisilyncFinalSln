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
            bool isUserLoggedIn = _database._dbConnection.Table<User>().Count() != 0;
            
            if (isUserLoggedIn)
            {
                await Shell.Current.GoToAsync("///athleteDash");
            }
            else
            {
                await Shell.Current.GoToAsync("///tellUsPage");
            }
            base.OnStart();
        }
    }
}

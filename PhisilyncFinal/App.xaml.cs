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
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {

            await Shell.Current.GoToAsync("TellUs");

        }
    }
}

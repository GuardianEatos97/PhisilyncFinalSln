using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Views;

namespace PhisilyncFinal
{
    
    public partial class AppShell : Shell
    {
<<<<<<< Updated upstream
        //public LocalDb _database;
        public AppShell()
        {
           // _database = new();
            InitializeComponent();
            //LoadAthleteDash();
        }


        //public void LoadAthleteDash()
        //{
        //    if (_database._dbConnection.Table<User>().Count() != 0)
        //    {
        //        Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
        //        Navigation.PushAsync(new AthleteDash());
        //    }
        //}


=======

        public AppShell()
        {
            InitializeComponent();
        }

>>>>>>> Stashed changes
    }
}

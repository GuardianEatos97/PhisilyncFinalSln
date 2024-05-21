using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.Views;

namespace PhisilyncFinal
{
    
    public partial class AppShell : Shell
    {
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


    }
}

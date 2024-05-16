using PhisilyncFinal.Models;
using PhisilyncFinal.Tabs;

namespace PhisilyncFinal
{
    
    public partial class AppShell : Shell
    {
        public User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public AppShell()
        {
            User = new User();
            InitializeComponent();
            LoadAthleteDash();
        }


        public void LoadAthleteDash()
        {
            if (User.userID != null)
            {
                Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
                Navigation.PushAsync(new AthleteDash());
            }
            else
            { 
            Routing.RegisterRoute("TellUsAboutYourself", typeof(TellUsPage));
                Navigation.PushAsync(new TellUsPage());
            }
        }

    }
}

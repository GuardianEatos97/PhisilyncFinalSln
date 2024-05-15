using PhisilyncFinal.Tabs;

namespace PhisilyncFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
            Navigation.PushAsync(new AthleteDash());
        }
    }
}

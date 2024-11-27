using ConstitucionDelEcuador.GUI;
using Xamarin.Forms;

namespace ConstitucionDelEcuador
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GUI_MenuLateral());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
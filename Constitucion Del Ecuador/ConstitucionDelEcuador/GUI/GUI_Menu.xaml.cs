using MarcTron.Plugin;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConstitucionDelEcuador.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GUI_Menu : ContentPage
    {
        public static int IdTitulo;
        public GUI_Menu()
        {
            InitializeComponent();
        }

        public void MetodoInicio(object sender, EventArgs e)
        {
            VerAnuncio();
            Navigation.PushAsync(new GUI_Inicio());
        }

        public void MetodoAcercaDe(object sender, EventArgs e)
        {
            VerAnuncio();
            IdTitulo = 1; 
            Navigation.PushAsync(new GUI_Seccion());
        }

        public void MetodoContacto(object sender, EventArgs e)
        {
            VerAnuncio();
            IdTitulo = 2;
            Navigation.PushAsync(new GUI_Seccion());
        }

        public void MetodoResumen(object sender, EventArgs e)
        {
            VerAnuncio();
            IdTitulo = 3;
            Navigation.PushAsync(new GUI_Seccion());
        }

        public void MetodoConstitucion(object sender, EventArgs e)
        {
            VerAnuncio();
            Navigation.PushAsync(new GUI_Constitucion());
        }

        public void VerAnuncio() 
        {
            CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-6065188311356970/2838244380");
            CrossMTAdmob.Current.ShowInterstitial();
        }
    }
}
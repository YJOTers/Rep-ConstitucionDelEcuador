using ConstitucionDelEcuador.Control;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConstitucionDelEcuador.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GUI_Constitucion : ContentPage
    {
        public GUI_Constitucion()
        {
            InitializeComponent();
            MetodoMostrarArticulo();
        }

        public async void MetodoMostrarArticulo()
        {
            try
            {
                C_WebAPI admin = new C_WebAPI();
                var listaArticulos = await admin.VerTodosLosArticulos();
                if (listaArticulos != null)
                {
                    if (string.IsNullOrEmpty(BuscarArticulo.Text))
                    {
                        ListaArticulos.ItemsSource = listaArticulos;
                    }
                    else 
                    {
                        string numArt = BuscarArticulo.Text;
                        string aux = "ART0000";
                        int index1 = aux.Length;
                        int index2 = numArt.Length;
                        int index = index1 - index2;
                        numArt = aux.Substring(0, index) + numArt;
                        var articulo = await admin.BuscarArticulo(numArt);
                        ListaArticulos.ItemsSource = articulo;
                    }
                }
            }
            catch (Exception) { }
        }

        private void BuscarArticulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            MetodoMostrarArticulo();
        }
    }
}
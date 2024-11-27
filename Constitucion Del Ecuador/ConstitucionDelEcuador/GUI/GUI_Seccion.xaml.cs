using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConstitucionDelEcuador.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GUI_Seccion : ContentPage
    {
        string Titulo = "";
        public GUI_Seccion()
        {
            InitializeComponent();
            switch (GUI_Menu.IdTitulo)
            {
                case 1:
                    Titulo = "ACERCA DE";
                    Texto.Text = "Para leer la constitución se requiere activar el internet.";
                    Foto.Source = "Acerca_de.jpg";
                    break;
                case 2:
                    Titulo = "CONTACTO";
                    Texto.Text = "Escribanos al correo emprendimiento2020g7h2@gmail.com para consultas o recomendaciones.";
                    Foto.Source = "Contacto.jpg";
                    break;
                case 3:
                    Titulo = "RESUMEN";
                    Texto.Text = "La constitución propone como objetivo construir una forma de convivencia ciudadana en diversidad y armonia con la naturaleza para alcanzar el buen vivir.";
                    Foto.Source = "Resumen.jpg";
                    break;
            }
            Title = Titulo;
        }
    }
}
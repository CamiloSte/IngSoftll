using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Libro.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarme : ContentPage
    {
        public Registrarme()
        {
            InitializeComponent();
        }
        public void MetodoRegistrar(object sender, System.EventArgs e)
        {
            DisplayAlert("Bienvenido", "Bienvenido", "Aceptar");
            ((NavigationPage)this.Parent).PushAsync(new PaginaUsuario());
        }
    }
}
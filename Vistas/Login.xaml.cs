using Libro.Modelo;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public void MetodoIniciarSesion(object sender, System.EventArgs e)
        {
            Usuario user = new Usuario(Entry_Correo.Text, Entry_Contraseña.Text);
            if (user.Comprobar())
            {
                DisplayAlert("Bienvenido", "Bienvenido", "Aceptar");
                ((NavigationPage)this.Parent).PushAsync(new PaginaUsuario());
                
            }
            else
            {

                DisplayAlert("Datos Incorrectos", "El correo o contraseña son incorrectos", "Cerrar");
                ((NavigationPage)this.Parent).PushAsync(new Login());
            }
        }

        public void MetodoRegistrar(object sender, System.EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Registrarme());
        }

    }
}
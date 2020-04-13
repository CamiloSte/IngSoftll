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
    public partial class PaginaUsuario : ContentPage
    {
        public PaginaUsuario()
        {
            InitializeComponent();
        }

        public void MetodoVolver(object sender, System.EventArgs e)
        {
           
                ((NavigationPage)this.Parent).PushAsync(new Login());
            
        }
    }
}
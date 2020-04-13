using Libro.Data;
using Libro.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Libro
{
    public partial class App : Application
    {

       public static TokenBaseController tokenController;
       public static UsuarioBaseController usuarioController;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
        public UsuarioBaseController UsuarioController
        {
            get
            {
                if (usuarioController==null)
                {
                    usuarioController = new UsuarioBaseController();
                }
                return usuarioController;
            }
        }
        public TokenBaseController TokenController
        {
            get
            {
                if (tokenController == null)
                {
                    tokenController = new TokenBaseController();
                }
                return tokenController;
            }
        }
    }
}

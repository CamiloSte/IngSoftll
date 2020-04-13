using Libro.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Libro.Data
{
    public class UsuarioBaseController
    {
        static object locker = new object();
        SQLiteConnection database;
        
        public UsuarioBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Usuario>();
        }

        public Usuario GetUsuario()
        {
            lock (locker)
            {
                if (database.Table<Usuario>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Usuario>().First();
                }
            }
        }
        public int guardarUsuariio(Usuario usuario)
        {
            lock (locker)
            {
                if (usuario.Correo !="")
                {
                    database.Update(usuario);
                    return usuario.Id;
                }
                else
                {
                    return database.Insert(usuario.Correo,usuario.Contraseña);
                }
            }
        }
        public int eliminarUsuario(int Id)
        {
            lock (locker)
            {
                return database.Delete<Usuario>(Id);
            }
        }
    }
}

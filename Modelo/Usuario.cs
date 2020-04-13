using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libro.Modelo
{
    public class Usuario
    {
        [PrimaryKey]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String Contraseña { get; set; }

        public Usuario()
        {

        }
        public Usuario(String Correo, String Contraseña)
        {
            this.Correo = Correo;
            this.Contraseña = Contraseña;

        }
        public bool Comprobar()
        {
            if (this.Correo.Equals("Camilo1234@hotmail.com") && !this.Contraseña.Equals("122345"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


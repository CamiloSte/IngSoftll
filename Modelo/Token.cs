using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libro.Modelo
{
   public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public String AccesoToken { get; set; }
        public String DescripcionError { get; set; }
        public DateTime FechaAtual { get; set; }

        public Token()
        {

        }
    }
}

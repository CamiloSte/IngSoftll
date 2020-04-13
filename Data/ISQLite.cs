using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libro.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

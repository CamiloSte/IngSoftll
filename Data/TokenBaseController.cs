using Libro.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Libro.Data
{
    public class TokenBaseController
    {
        static object locker = new object();
        SQLiteConnection database;

        public TokenBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();
        }

        public Token GetToken()
        {
            lock (locker)
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }
        public int guardarToken(Token token)
        {
            lock (locker)
            {
                if (token.Id != 0)
                {
                    database.Update(token);
                    return token.Id;
                }
                else
                {
                    return database.Insert(token);
                }
            }
        }
        public int eliminarToken(int Id)
        {
            lock (locker)
            {
                return database.Delete<Token>(Id);
            }
        }
    
}
}

using DbConnFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DataWorker
    {
        private static Database _database = null;
        static DataWorker()
        {
            try
            {
                _database = DatabaseFactory.CreateDatabase("Prueba4");
            }
            catch (Exception excep)
            {
                throw excep;
            }
        }
        public static Database database
        {
            get { return _database; }
        }
    }
}

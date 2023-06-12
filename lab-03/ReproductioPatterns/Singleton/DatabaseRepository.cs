using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class DatabaseRepository
    {
        private static DatabaseRepository? _Instance; 

        private static Object obj = new Object();
        private DatabaseRepository() {
            Console.WriteLine("Initializing Single...................");
        }

        public static DatabaseRepository GetInstance()
        {
            if (DatabaseRepository._Instance == null)
            {
                lock (obj)
                {
                    if (DatabaseRepository._Instance == null)
                    {
                        DatabaseRepository._Instance = new DatabaseRepository();
                    }
                }
            }
            return DatabaseRepository._Instance;
        }
    }
}

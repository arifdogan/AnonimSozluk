using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static DatabaseContext context;
        static Object lockObject = new Object();

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (context == null)
            {
                lock (lockObject)
                {
                    if (context == null)
                    {
                        DatabaseContext context = new DatabaseContext();
                    }
                }
            }
        }
    }
}

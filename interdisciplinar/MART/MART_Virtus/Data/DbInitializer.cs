using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MART_Virtus.Data
{
    public class DbInitializer
    {
        public static void Initialize(BaseDeDados db)
        {
            db.Database.EnsureCreated();
        }
    }
}

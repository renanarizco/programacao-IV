using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProjeto1.Data
{
    public class DbInitializer
    {
        public static void Initialize(BaseDeDados db)
        {
            //acionar a criação do banco de dados
            db.Database.EnsureCreated();
        }

    }
}

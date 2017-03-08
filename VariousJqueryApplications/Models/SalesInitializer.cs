using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VariousJqueryApplications.Models
{
    public class SalesInitializer : CreateDatabaseIfNotExists<SalesContext>
    {
        protected override void Seed(SalesContext context)
        {
            List<Il> iller = new List<Il>()
            {
                new Il { Id = 35, Name = "Izmir" }
            };

            List<Ilce> ilceler = new List<Ilce>()
            {
                new Ilce { Id = 1, IlId = 35, Name = "Aliağa" },
                new Ilce { Id = 2, IlId = 35, Name = "Alsancak" },
                new Ilce { Id = 3, IlId = 35, Name = "Karşıyaka" }
            };

            iller.ForEach(il => context.Iller.Add(il));
            ilceler.ForEach(ilce => context.Ilceler.Add(ilce));
            context.SaveChanges();
        }
    }
}
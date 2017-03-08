using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VariousJqueryApplications.Models
{
    public class Il
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
    }
}
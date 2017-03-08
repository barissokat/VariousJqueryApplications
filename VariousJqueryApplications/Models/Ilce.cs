using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace VariousJqueryApplications.Models
{
    public class Ilce
    {
        public int Id { get; set; }
        public int IlId { get; set; }
        public string Name { get; set; }
        public virtual Il Il { get; set; }
    }
}
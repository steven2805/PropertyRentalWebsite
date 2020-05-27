using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RentalWebPortal.Models
{
    public class Property
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public TYPE Type { get; set; }
    }
}

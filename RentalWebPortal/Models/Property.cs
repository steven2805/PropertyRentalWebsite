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
        // Exactly how it sounds paid highlight adverts
        public bool PremiumListing { get; set; }

        public string Description { get; set; }
        public decimal Cost { get; set; }

        public DateTime ListedDate { get; set; }

        public List<FilePath> ImagePath { get; set; }
        //You would need multiple addresslines but for now 1 will do

        public string AddressLine1 { get; set; }
        public string Postcode { get; set; }
    }
}

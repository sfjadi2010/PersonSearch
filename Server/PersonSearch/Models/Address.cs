using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string Country { get; set; }

        public string Postal { get; set; }
        public AddressType Type { get; set; }
    }
}

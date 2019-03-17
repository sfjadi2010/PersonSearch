using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [StringLength(120)]
        public string City { get; set; }

        [StringLength(120)]
        public string State { get; set; }

        [StringLength(120)]
        public string Country { get; set; }

        [Required]
        [StringLength(5)]
        public string Postal { get; set; }
        public AddressType Type { get; set; }
    }
}

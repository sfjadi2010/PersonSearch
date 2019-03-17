using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public string Interests { get; set; }

        public string ImageName { get; set; }
        public virtual List<Address> Address { get; set; }
    }
}

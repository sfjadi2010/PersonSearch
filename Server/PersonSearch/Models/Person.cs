using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonSearch.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual List<Address> Address { get; set; }
    }
}

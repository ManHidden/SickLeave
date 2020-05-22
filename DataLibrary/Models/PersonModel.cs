using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public long PESEL { get; set; }
    }
}

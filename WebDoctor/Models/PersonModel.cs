using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebDoctor.Models
{
    public class PersonModel
    {
        [Display(Name = "Imię")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Musisz podać poprawne imię")]
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        
        [Display(Name = "Nazwisko")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Musisz podać poprawne nazwisko")]
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
       
        [Display(Name = "Data urodzenia")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Musisz podać poprawną datę urodzenia")]
        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false)]
        public string BirthDay { get; set; }

        [Display(Name = "PESEL")]
        [Required, Range(00000000001, 99999999999, ErrorMessage = "Musisz podać poprawny PESEL")]
        [MinLength(11, ErrorMessage = "Podany PESEL jest zbyt krótki")]
        public string PESEL { get; set; }
    }

}
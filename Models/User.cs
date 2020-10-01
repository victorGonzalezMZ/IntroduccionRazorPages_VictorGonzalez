using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionRazorPages.Models
{
    public class User
    {
        public int ID { get; set; }
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Username length can't be more than 15 and minimum than 3.")]
        public string Username { get; set; }

        [RegularExpression(@"^[a-zA-Z]\w{3,14}$", ErrorMessage = "The password's first character must be a letter,"+
            " it must contain at least 4 characters and no more than 15 characters and no characters other than letters,"+
            " numbers and the underscore may be used")]
        [Required]
        [StringLength(15, MinimumLength = 4)]
        public string Password { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [StringLength(50,ErrorMessage = "The {0} value cannot exceed {1} characteres")]
        public string Name { get; set; }

    }
}

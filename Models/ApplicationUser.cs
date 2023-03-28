using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(2)]
        public int Age { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }


        public byte[] ProfileImg { get; set; }
    }
}


public enum Gender
{

    MALE,
    FEMALE
}
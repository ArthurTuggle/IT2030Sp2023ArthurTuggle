using System.ComponentModel.DataAnnotations;

namespace ArthurMusic_Lounge.Models
{
    public class ContactModel
    {
        //add ? to each data type to make them nullable for data validation to work properly
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}
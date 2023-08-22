using System.ComponentModel.DataAnnotations;

namespace PersonEntry.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required] 
        public string LastName { get;set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}

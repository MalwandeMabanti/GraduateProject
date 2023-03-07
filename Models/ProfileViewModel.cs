using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace NewProject.Models
{
    public class ProfileViewModel


    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Country{ get; set; }
        public string City { get; set; }


    }
}

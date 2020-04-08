using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W2D2_StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, MinLength(2, ErrorMessage = "Your First Name needs to be longer than 1 character"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, MinLength(2, ErrorMessage = "Your Last Name needs to be longer than 1 character"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Phone { get; set; }
    }
}

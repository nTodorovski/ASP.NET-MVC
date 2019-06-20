using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Author(int id,string firstName,string lastName,int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Author()
        {

        }
    }
}

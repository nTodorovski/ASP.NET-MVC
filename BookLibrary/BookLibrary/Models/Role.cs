using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Display(Name = "Role")]
        public string Name { get; set; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DtoModels
{
    public class Role : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Role")]
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }

        public Role(string name)
        {
            Name = name;
        }
    }
}

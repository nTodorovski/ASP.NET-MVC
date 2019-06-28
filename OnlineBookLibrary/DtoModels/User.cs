using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DtoModels
{
    public class User : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Email { get; set; }
        [Required]
        [MinLength(3)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public bool IsLogged { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            IsLogged = false;
        }

        public User()
        {

        }
    }
}

namespace BookLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(int id, string email, string password, Role role)
        {
            Id = id;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
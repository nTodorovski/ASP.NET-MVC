using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.ViewModels;

namespace BookLibrary.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User user)
        {
            _userRepository.CreateNew(user);
        }

        public void DeleteExisting(User user)
        {
            _userRepository.DeleteExisting(user);
        }

        public User GetUserById(int id)
        {
            User user = _userRepository.GetItemDetails(id);
            return user;
        }

        public List<User> ListAll()
        {
            return _userRepository.ListAll();
        }

        public void UpdateExisting(User user)
        {
            _userRepository.UpdateExisting(user);
        }

        public User ChangeToModel(UserViewModel model)
        {
            var user = new User();
            user.Email = model.Email;
            user.Password = model.Password;
            return user;
        }

        public User FindUser(User user)
        {
            var newUser = Storage.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            return newUser;
        }

        public User FindUserByEmail(string email)
        {
            var user = Storage.Users.FirstOrDefault(x => x.Email == email);
            return user;
        }

        public bool CheckIfSomeoneIsLogged()
        {
            var IsLogged = Storage.Users.Exists(x => x.IsLogged == true);
            return IsLogged;
        }

        public User FindLoggedUser()
        {
            var loggedUser = Storage.Users.Find(x => x.IsLogged == true);
            return loggedUser;
        }
    }
}

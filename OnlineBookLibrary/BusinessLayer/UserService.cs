using DataLayer;
using DtoModels;
using ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public void DeleteExisting(User user)
        {
            _userRepository.Delete(user);
        }

        public User GetUserById(int id)
        {
            User user = _userRepository.GetById(id);
            return user;
        }

        public List<User> ListAll()
        {
            return _userRepository.GetAll();
        }

        public void UpdateExisting(User user)
        {
            _userRepository.Update(user);
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
            var newUser = _userRepository.GetAll().FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            return newUser;
        }

        public User FindUserByEmail(string email)
        {
            var user = _userRepository.GetAll().FirstOrDefault(x => x.Email == email);
            return user;
        }

        public bool CheckIfSomeoneIsLogged()
        {
            var IsLogged = _userRepository.GetAll().Exists(x => x.IsLogged == true);
            return IsLogged;
        }

        public User FindLoggedUser()
        {
            var loggedUser = _userRepository.GetAll().Find(x => x.IsLogged == true);
            return loggedUser;
        }
    }
}

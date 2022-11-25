using System.Linq;
using LogowanieSortowanie.Model;

namespace LogowanieSortowanie
{
    class LoginValidator
    {
        private UserModel _userModel;
        private UserModel[] _users = new UserModel[]
        {
            new UserModel { Login = "admin", Password = "admin" },
            new UserModel { Login = "user", Password = "user" },
            new UserModel { Login = "user1", Password = "password" }
        };

        public LoginValidator(UserModel userModel)
        {
            _userModel = userModel;
        }

        public bool Validate()
        {
            // if _userModel == any of _users and _userModel.Password == _users.Password return true
            return _users.Any(user => user.Login == _userModel.Login && user.Password == _userModel.Password);
        }
    }
}

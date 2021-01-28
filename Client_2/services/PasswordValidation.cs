using Client.ingredients;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_2.services
{
    class PasswordValidation : CredentialValidation
    {


        private String _user;
        private String _password;
        private Client.ingredients.UserService _userService;

        public PasswordValidation(String user, String pass, UserService userService)
        {
            _user = user;
            _password = pass;
            _userService = userService;
        }

        public User retrieveUser()
        {
            var user = _userService.GetByUserName(_user);

            if (user != null || user.Pass == _password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}

using Client.ingredients;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_2.services
{
    class PinValidation : CredentialValidation
    {
        private String _pin;
        private UserService _userService;

        public PinValidation(String pin, UserService userService)
        {
            _pin = pin;
            _userService = userService;
        }


        public User retrieveUser()
        {
            return _userService.GetByPin(_pin);
        }
    }
}

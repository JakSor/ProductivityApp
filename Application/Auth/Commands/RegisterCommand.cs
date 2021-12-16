using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Commands
{
    public class RegisterCommand
    {
        public LoginModel LoginModel { get; set; }

        public RegisterCommand(LoginModel login)
        {
            LoginModel = login;
        }
    }
}

using Common.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Commands
{
    public class LoginCommand : IRequest<int>
    {
        public LoginModel LoginModel { get; set; }
        public LoginCommand(LoginModel login)
        {
            LoginModel = login;
        }
    }

    public class LoginHandler : IRequestHandler<LoginCommand, int>
    {
        public Task<int> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

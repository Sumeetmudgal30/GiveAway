using System;
namespace GiveAway.Core.Services
{

    public interface IAuthenticateService
    {
        bool AuthenticateUser(string Name, string Password);
    }


    public class AuthenticateService:IAuthenticateService
    {
        public AuthenticateService()
        {
            
        }


        public bool AuthenticateUser(string Name, string Password)
        {
            return true;
        }

    }
}

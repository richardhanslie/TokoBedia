using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class LoginHandler
    {
        public static User DoLogin(string email, string password)
        {
            User u = UserRepository.GetUser(email, password);
            return u;
        }
    }
}
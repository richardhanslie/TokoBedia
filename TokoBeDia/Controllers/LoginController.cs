using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Model;

namespace TokoBeDia.Controllers
{
    public class LoginController
    {
        public static User DoLogin(string email, string password)
        {
            User u = LoginHandler.DoLogin(email, password);
            return u;
        }
    }
}
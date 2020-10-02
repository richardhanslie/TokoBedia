using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factories
{
    public class UserFactory
    {
        public static User RegisterUser(string email,int roleId, string name, string password, string gender, string status)
        {
            User u = new User()
            {
                Email = email,
                RoleId = roleId,
                Name = name,
                Password = password,
                Gender = gender,
                Status = status
            };
            return u;
        }
    }
}
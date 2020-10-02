using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Controllers
{
    public class UserController
    {
        public static Response DoRegister(string email, int roleId, string name, string password, string gender, string status, string confirmPassword)
        {
            
            User getEmail = UserHandler.GetEmail(email);

            if (email == "")
            {
                return new Response(false, "email must be filled");
            }
            else if (getEmail != null)
            {
                return new Response(false, "email must be unique");
            }
            else if (name == "")
                return new Response(false, "name must be filled");
            else if (password == "")
                return new Response(false, "password must be filled");
            else if (confirmPassword != password)
                return new Response(false, "must be same with password");
            else if(gender == "")
                return new Response(false, "gender must be choose");
            else
            {
                User u = UserHandler.DoRegister(email, roleId, name, password, gender, status);
                return new Response(true);
            }
        }

        public static User GetId(int id)
        {
            User u = UserHandler.GetId(id);
            return u;
        }

        public static Response UpdateProfile(int id, string name, string email, string gender)
        {
            User getEmail = UserHandler.GetEmail(email);

            if (email == "")
            {
                return new Response(false, "email must be filled");
            }
            else if (getEmail != null)
            {
                return new Response(false, "email must be unique");
            }
            else if (name == "")
                return new Response(false, "name must be filled");
            else if (gender == "")
                return new Response(false, "gender must be choose");
            else
            {
                User u = UserHandler.UpdateProfile(id, name, email, gender);
                return new Response(true);
            }
        }

        public static Response ChangePassword(int id, string newPassword, string oldPassword, string confirmPassword)
        {
            User u = UserHandler.GetId(id);

            if (oldPassword != u.Password)
            {
                return new Response(false, "must match with you old password");
            }
            else if (newPassword.Length < 5)
            {
                return new Response(false, "must be longer than 5 characters");
            }
            else if (newPassword != confirmPassword)
            {
                return new Response(false, "your password didn't match with new password");
            }
            else
            {
                UserHandler.ChangePassword(u.Id, newPassword);
                return new Response(true);
            }
        }

        public static List<ViewUser> GetAllUser(int id)
        {
            List<ViewUser> u = UserHandler.GetAllUser(id);
            return u;
        }

        public static User AllowUser(int id)
        {
            User u = UserHandler.AllowUser(id);
            return u;
        }

        public static User BlockUser(int id)
        {
            User u = UserHandler.BlockUser(id);
            return u;
        }

        public static User ChangeToAdminitrator(int id)
        {
            User u = UserHandler.ChangeToAdminitrator(id);
            return u;
        }

        public static User ChangeToMember(int id)
        {
            User u = UserHandler.ChangeToMember(id);
            return u;
        }
    }
}
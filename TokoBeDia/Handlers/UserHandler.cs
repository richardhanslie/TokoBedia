using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class UserHandler
    {
        public static User DoRegister(string email, int roleId, string name, string password, string gender, string status)
        {
            User u = UserRepository.RegisterUser(email, roleId, name, password, gender, status);
            return u;
        }

        public static User GetEmail(string email)
        {
            User u = UserRepository.GetUserEmail(email);
            return u;
        }
        
        public static User GetId(int id)
        {
            User u = UserRepository.GetId(id);
            return u;
        }

        public static User UpdateProfile(int id, string name, string email, string gender)
        {
            User u = UserRepository.UpdateProfile(id, name, email, gender);
            return u;
        }

        public static User ChangePassword(int id, string password)
        {
            User u = UserRepository.ChangePassword(id, password);
            return u;
        }

        public static List<ViewUser> GetAllUser(int id)
        {
            User userId = GetId(id);
            List<ViewUser> u = UserRepository.GetAllUser(userId.Id);
            return u;
        }

        public static User AllowUser(int id)
        {
            User u = UserRepository.AllowUser(id);
            return u;
        }

        public static User BlockUser(int id)
        {
            User u = UserRepository.BlockUser(id);
            return u;
        }

        public static User ChangeToAdminitrator(int id)
        {
            User u = UserRepository.ChangeToAdminitrator(id);
            return u;
        }

        public static User ChangeToMember(int id)
        {
            User u = UserRepository.ChangeToMember(id);
            return u;
        }
    }
}
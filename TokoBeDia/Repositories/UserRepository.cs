using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Repositories
{
    public class UserRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static User RegisterUser(string email,int roleId, string name, string password, string gender, string status)
        {
            User u = UserFactory.RegisterUser(email, roleId, name, password, gender, status);

            db.Users.Add(u);
            db.SaveChanges();
            return u;
        }

        public static User UpdateProfile(int id, string name, string email, string gender)
        {
            User u = GetId(id);
            u.Name = name;
            u.Email = email;
            u.Gender = gender;

            db.SaveChanges();
            return u;
        }

        public static User ChangePassword(int id, string newPassword)
        {
            User u = GetId(id);
            u.Password = newPassword;
            db.SaveChanges();
            return u;
        }

        public static List<ViewUser> GetAllUser(int id)
        {
            List<ViewUser> u = (from a in db.Users where a.Id != id select 
                            new ViewUser()
                            {
                                Id = a.Id,
                                Role = a.Role.Name,
                                Name = a.Name,
                                Email = a.Email,
                                Gender = a.Gender,
                                Status = a.Status
                            }).ToList();

            return u;
        }

        public static User GetUser(string email, string password)
        {
            User u = (from a in db.Users where a.Email == email && a.Password == password select a).FirstOrDefault();
            return u;
        }

        public static User GetUserEmail(string email)
        {
            User u = (from a in db.Users where a.Email == email select a).FirstOrDefault();
            return u;
        }

        public static User GetId(int id)
        {
            User u = (from a in db.Users where a.Id == id select a).FirstOrDefault();
            return u;
        }

        public static User AllowUser(int id)
        {
            User u = GetId(id);
            u.Status = "Allow";
            db.SaveChanges();
            return u;
        }

        public static User BlockUser(int id)
        {
            User u = GetId(id);
            u.Status = "Blocked";
            db.SaveChanges();
            return u;
        }

        public static User ChangeToAdminitrator(int id)
        {
            User u = GetId(id);
            u.RoleId = 1;
            db.SaveChanges();
            return u;
        }

        public static User ChangeToMember(int id)
        {
            User u = GetId(id);
            u.RoleId = 2;
            db.SaveChanges(); ;
            return u;
        }
    }
}
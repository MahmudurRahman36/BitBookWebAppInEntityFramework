using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookWebApplication.Models;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.DAL
{
    public class UserGateway
    {
        BBWAContext _db=new BBWAContext();
        
        public List<Gender> GetAllGenders()
        {
            return _db.Genders.ToList();
        }

        public bool IsUserEmailExist(User user)
        {
            return _db.Users.Any(x => x.Email.ToLower()==user.Email.ToLower());
        }
        public int AddUser(User user)
        {
            _db.Users.Add(user);
            return _db.SaveChanges();
        }
    }
}
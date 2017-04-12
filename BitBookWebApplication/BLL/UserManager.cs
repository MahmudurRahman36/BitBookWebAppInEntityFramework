using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookWebApplication.DAL;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.BLL
{
    public class UserManager
    {
        UserGateway _userGateway=new UserGateway();

        public List<Gender> GetAllGenders()
        {
            return _userGateway.GetAllGenders();
        }

        public bool IsUserEmailExist(User user)
        {
            return _userGateway.IsUserEmailExist(user);
        }
        public int AddUser(User user)
        {
            return _userGateway.AddUser(user);
        }
    }
}
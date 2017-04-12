using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookWebApplication.Models;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.DAL
{
    public class PersonGateway
    {
        BBWAContext _db=new BBWAContext();
        public int AddPerson(Person person)
        {
            _db.Persons.Add(person);
            return _db.SaveChanges();
        }
    }
}
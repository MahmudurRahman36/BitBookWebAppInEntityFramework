using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookWebApplication.DAL;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.BLL
{
    public class PersonManager
    {
        PersonGateway _personGateway=new PersonGateway();

        public int AddPerson(Person person)
        {
            return _personGateway.AddPerson(person);
        }
    }
}
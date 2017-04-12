using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookWebApplication.Models.Entity
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; } 
    }
}
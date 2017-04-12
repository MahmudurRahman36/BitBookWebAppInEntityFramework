using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.Models
{
    public class BBWAContext:DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Gender> Genders { set; get; }
        public DbSet<AdditionInformationOfUser> AdditionInformationOfUsers { set; get; } 
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitBookWebApplication.Models.Entity
{
    public class ProfilePhoto
    {
        public int Id { get; set; }
        public int TypeNo { get; set; }
        public byte[] PhotoInByte { get; set; }
        [NotMapped]
        public string PhotoInString { get; set; }
        public int AdditionInformationOfUserId { get; set; }
        public AdditionInformationOfUser AdditionInformationOfUser { get; set; }
        public DateTime DateTimeNow { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitBookWebApplication.Models.Entity
{
    public class AdditionInformationOfUser
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public User User { get; set; }
        [NotMapped] 
        public int ProfilePhotoId { get; set; }
        [NotMapped] 
        public HttpPostedFileBase ProfilePhoto { get; set; }
        public byte[] PhotoInByte { get; set; }
        [NotMapped] 
        public int CoverPhotoId { get; set; }
        [NotMapped] 
        public HttpPostedFileBase CoverPhoto { get; set; }
        public byte[] CoverPhotoInByte { get; set; }
        public string AboutMe { get; set; }
        public string Religion { get; set; }
    }
}
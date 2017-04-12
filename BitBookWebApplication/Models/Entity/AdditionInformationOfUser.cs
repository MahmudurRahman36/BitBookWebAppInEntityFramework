using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int ProfilePhotoId { get; set; }
        public List<ProfilePhoto> ProfilePhotos { get; set; }
        [NotMapped]
        public HttpPostedFileBase ProfilePhoto { get; set; }
        public int CoverPhotoId { get; set; }
        public List<CoverPhoto> CoverPhotos { get; set; }
        [NotMapped] 
        public HttpPostedFileBase CoverPhoto { get; set; }
        public string AboutMe { get; set; }
        public string Religion { get; set; }
    }
}
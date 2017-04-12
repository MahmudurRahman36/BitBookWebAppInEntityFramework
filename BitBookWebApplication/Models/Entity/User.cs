using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitBookWebApplication.Models.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email Address not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Email")]
        [Compare("Email")]
        [NotMapped]
        public string ConfirmEmail { get; set; }

        public string MobileNo { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        [NotMapped]                                //this value wont store in database
        public string ConfirmPassword { get; set; }

        [Display(Name = "Date Of Birth")]
        [Column(TypeName = "Date")]                  //datetime type=date
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        
        public DateTime DateOfBirth { get; set; }   //To use dateTime there must be textboxFor no texteditor for in the view
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public AdditionInformationOfUser AdditionInformationOfUser { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace playerhotlist.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Your username")]
        public string name { get; set; }

        [Required(ErrorMessage = "Account password is required")]
        [Display(Name = "Account password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public int roleID { get; set; } 

        public Account()
        {

        }

        public Account(string password, string name, int roleID)
        {
            this.password = password;
            this.name = name;
            this.roleID = roleID;
        }
    }

    public class RegisterModel
    {
        [Required(ErrorMessage = "Account name is required")]
        [Display(Name = "Your name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Account password is required")]
        [Display(Name = "Account password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Account password is required")]
        [Display(Name = "Account password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match")]
        public string confirmPassword { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestForms2.Models
{
    public class UserInfo
    {   
        [Required]
        public string Username { set; get; }

        [Required]
        public string Password { set; get; }

        [Required]
        [RegularExpression(@"^([\w\.\-] +)@([\w\-] +)((\.(\w){2, 3})+)$",ErrorMessage ="Bad Email!")]
        public string Email { set; get; }

        public UserInfo()
        {
        }
        public UserInfo(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
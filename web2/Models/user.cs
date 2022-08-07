using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVCRegistration.Models
{
    //getting the users datas and setting the needed parameters 
    public class user
    {
        public int UserID
        {
            get; set;
        }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        public string Username
        {
            get; set;
        }
        [Required(ErrorMessage = "Please provide Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be 8 char long.")]
        public string Password
        {
            get; set;
        }
        [Compare("Password", ErrorMessage = "Confirm password dose not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfirmPassword
        {
            get; set;
        }
        [Required(ErrorMessage = "Please provide full name", AllowEmptyStrings = false)]
        public string FullName
        {
            get; set;
        }

        public string EmailID
        {
            get; set;
        }

    }
}
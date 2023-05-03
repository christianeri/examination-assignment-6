using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-öA-Ö]+(?:[é'-][a-öA-Ö]+)*$", ErrorMessage = "You must enter a valid first name")]
        public string FirstName { get; set; } = null!;


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-öA-Ö]+(?:[é'-][a-öA-Ö]+)*$", ErrorMessage = "You must enter a valid last name")]
        public string LastName { get; set; } = null!;


        [Display(Name = "E-mail Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-mail address is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; } = null!;


        [Display(Name = "Phone Number (optional)")]
        public string? PhoneNumber { get; set; }


        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "Password must be at least 8 characters, must contain an upper case letter, a lower case letter and a number")]
        public string Password { get; set; } = null!;


        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirming password is required")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null!;


        [Display(Name = "Street (optional)")]
        public string? StreetName { get; set; }


        [Display(Name = "Postal Code (optional)")]
        public string? PostalCode { get; set; }


        [Display(Name = "City (optional)")]
        public string? City { get; set; }





        //public static implicit operator CustomIdentityUser(SignUpViewModel signupViewModel)
        public static implicit operator IdentityUser(SignUpViewModel model)
        {
            //return new CustomIdentityUser
            return new IdentityUser
            {
                UserName = model.Email,

                //FirstName = model.FirstName,
                //LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };
        }





        public static implicit operator UserProfileEntity(SignUpViewModel model)
        {
            return new UserProfileEntity
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                StreetName = model.StreetName,
                PostalCode = model.PostalCode,
                City = model.City
            };
        }
    }
}

using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class RegisterContactViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;          
        
        
        [Display(Name = "Phone Number (optional)")]
        public string PhoneNumber { get; set; }        
        

        [Display(Name = "Organization (optional)")]
        public string Organization { get; set; }


        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string Message { get; set; } = string.Empty;



        public static implicit operator ContactEntity(RegisterContactViewModel registerContactViewModel)
        {
            return new ContactEntity
            {
                Name = registerContactViewModel.Name,
                Email = registerContactViewModel.Email,
                PhoneNumber = registerContactViewModel.PhoneNumber,
                Organization = registerContactViewModel.Organization,
                Message = registerContactViewModel.Message
            };
        }
    }
}

using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.ViewModels
{
    public class RegisterContactViewModel
    {

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Email Address")]
        public string? Email { get; set; }           
        
        
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }        
        

        [Display(Name = "Organization")]
        public string? Organization { get; set; }


        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string? Message { get; set; }



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

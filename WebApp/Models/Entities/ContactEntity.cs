using WebApp.Dtos;

namespace WebApp.Models.Entities
{
    public class ContactEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }
        public string Message { get; set; } = string.Empty;





        public static implicit operator ContactDto(ContactEntity entity)
        {
            return new ContactDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                Organization = entity.Organization,
                Message = entity.Message
            };
        }
    }
}

namespace WebApp.Models.Entities
{
    public class ContactEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }
        public string Message { get; set; }





        public static implicit operator ContactModel(ContactEntity entity)
        {
            return new ContactModel
            {
                Id = entity.Id,
                Name = entity?.Name,
                Email = entity?.Email,
                PhoneNumber = entity?.PhoneNumber,
                Organization = entity?.Organization,
                Message = entity?.Message
            };
        }
    }
}

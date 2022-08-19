namespace RealEstateApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Province { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public string DefinitionAddress { get; set; }
        public ICollection<User> User { get; set; }
    }
}

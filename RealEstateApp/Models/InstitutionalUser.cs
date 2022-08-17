using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Models
{
    public class InstitutionalUser
    {
        [Key,ForeignKey("Users")]
        public int UserId { get; set; }
        public string InstitutionalName { get; set; }
        public string InstitutionalMail { get; set; }
        public string InstitutionalPhone { get; set; }
        public string InstitutionalDocument { get; set; }

        public Users Users { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MusteriNo { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        //public string Province { get; set; }

        //public string District { get; set; }

        //public string Street { get; set; }
        public DateTime CreatedDataTime { get; set; } = DateTime.Now;
        public bool Active { get; set; }

        public InstitutionalUser Institutionals { get; set; }



    }
}

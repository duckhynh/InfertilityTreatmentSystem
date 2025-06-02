using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.Models
{
    public class InfoDoctor
    {
        [Key]
        public int Info_ID { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }

        [StringLength(255)]
        public string Certificate { get; set; }

        public int? Experian_Year { get; set; }

        [StringLength(100)]
        public string Full_Name { get; set; }

        [StringLength(100)]
        public string Speciality { get; set; }

        [StringLength(100)]
        public string Degree { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone_Number { get; set; }

        // Navigation
        public User User { get; set; }
    }
}

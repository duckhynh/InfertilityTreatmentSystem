using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.Models
{
    public class Member
    {
        [Key]
        public int Member_ID { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone_Number { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        // Navigation
        public User User { get; set; }
    }
}

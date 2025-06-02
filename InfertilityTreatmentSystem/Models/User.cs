using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [ForeignKey("Role")]
        public int Role_ID { get; set; }

        [Required, StringLength(100)]
        public string User_Name { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        // Navigation
        public Role Role { get; set; }
        public InfoDoctor InfoDoctor { get; set; }
        public Member Member { get; set; }
    }
}

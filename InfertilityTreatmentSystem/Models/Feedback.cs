using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Feedback
{
    [Key]
    public int Feedback_ID { get; set; }

    [ForeignKey("User")]
    public int User_ID { get; set; }

    [StringLength(20)]
    public string Number_Phone { get; set; }

    [StringLength(500)]
    public string Content_Feedback { get; set; }

    public int Rating { get; set; }

    [StringLength(50)]
    public string Target_Type { get; set; }

    public DateTime Create_At { get; set; }

    public User User { get; set; }
}
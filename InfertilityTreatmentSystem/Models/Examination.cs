using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Examination
{
    [Key]
    public int Examination_ID { get; set; }

    [ForeignKey("Booking")]
    public int Booking_ID { get; set; }

    [ForeignKey("User")]
    public int User_ID { get; set; }

    public DateTime Date_Meet { get; set; }

    public Booking Booking { get; set; }
    public User User { get; set; }
}
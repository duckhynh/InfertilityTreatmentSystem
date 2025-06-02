using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    [Key]
    public int Booking_ID { get; set; }

    [ForeignKey("TreatmentService")]
    public int TreatmentService_ID { get; set; }

    [ForeignKey("User")]
    public int User_ID { get; set; }

    [StringLength(20)]
    public string Number_Phone { get; set; }

    [StringLength(50)]
    public string Status_Booking { get; set; }

    public DateTime Create_At { get; set; }

    public TreatmentService TreatmentService { get; set; }
    public User User { get; set; }
}
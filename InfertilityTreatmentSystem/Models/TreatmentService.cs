using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TreatmentService
{
    [Key]
    public int TreatmentService_ID { get; set; }

    [ForeignKey("User")]
    public int User_ID { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    public decimal Price { get; set; }

    [StringLength(500)]
    public string Descriptions { get; set; }

    [StringLength(50)]
    public string Durations { get; set; }

    public User User { get; set; }
}
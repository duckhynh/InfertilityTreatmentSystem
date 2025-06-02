using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MedicalRecord
{
    [Key]
    public int Record_ID { get; set; }

    [ForeignKey("TreatmentProcess")]
    public int TreatmentProcess_ID { get; set; }

    [StringLength(20)]
    public string Number_Phone { get; set; }

    [StringLength(500)]
    public string Summary { get; set; }

    public DateTime Created_At { get; set; }

    public TreatmentProcess TreatmentProcess { get; set; }
}
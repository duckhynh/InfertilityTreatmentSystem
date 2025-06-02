using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TreatmentProcess
{
    [Key]
    public int TreatmentProcess_ID { get; set; }

    public int MedicalRecords_ID { get; set; }

    [ForeignKey("Result")]
    public int Result_ID { get; set; }

    public DateTime Date_Treatment { get; set; }

    [StringLength(500)]
    public string Descriptions { get; set; }

    [StringLength(500)]
    public string Plan_Treatment { get; set; }

    public Result Result { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Result
{
    [Key]
    public int Result_ID { get; set; }

    [ForeignKey("Examination")]
    public int Examination_ID { get; set; }

    public int TreatmentProcess_ID { get; set; }

    [StringLength(500)]
    public string Result_Test { get; set; }

    public Examination Examination { get; set; }
}
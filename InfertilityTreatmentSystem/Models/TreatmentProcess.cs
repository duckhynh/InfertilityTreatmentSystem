using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class TreatmentProcess
{
    public int TreatmentProcessId { get; set; }

    public int? MedicalRecordsId { get; set; }

    public int? ResultId { get; set; }

    public DateOnly? DateTreatment { get; set; }

    public string? Descriptions { get; set; }

    public string? PlanTreatment { get; set; }

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual Result? Result { get; set; }
}

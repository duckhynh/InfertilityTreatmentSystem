using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class MedicalRecord
{
    public int RecordId { get; set; }

    public int? TreatmentProcessId { get; set; }

    public string? NumberPhone { get; set; }

    public string? Summary { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual TreatmentProcess? TreatmentProcess { get; set; }
}

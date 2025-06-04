using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Result
{
    public int ResultId { get; set; }

    public int? ExaminationId { get; set; }

    public int? TreatmentProcessId { get; set; }

    public string? ResultTest { get; set; }

    public virtual Examination? Examination { get; set; }

    public virtual ICollection<TreatmentProcess> TreatmentProcesses { get; set; } = new List<TreatmentProcess>();
}

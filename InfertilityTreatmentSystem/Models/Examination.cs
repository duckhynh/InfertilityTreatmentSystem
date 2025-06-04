using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Examination
{
    public int ExaminationId { get; set; }

    public int? BookingId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? DateMeet { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual User? User { get; set; }
}

using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? TreatmentServiceId { get; set; }

    public int? UserId { get; set; }

    public string? NumberPhone { get; set; }

    public string? StatusBooking { get; set; }

    public DateOnly? CreateAt { get; set; }

    public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();

    public virtual TreatmentService? TreatmentService { get; set; }

    public virtual User? User { get; set; }
}

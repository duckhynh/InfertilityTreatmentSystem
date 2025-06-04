using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class TreatmentService
{
    public int TreatmentServiceId { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Descriptions { get; set; }

    public string? Durations { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual User? User { get; set; }
}

using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public int? UserId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public virtual User? User { get; set; }
}

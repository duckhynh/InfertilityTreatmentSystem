using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int? UserId { get; set; }

    public string? NumberPhone { get; set; }

    public string? ContentNoti { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsRead { get; set; }

    public virtual User? User { get; set; }
}

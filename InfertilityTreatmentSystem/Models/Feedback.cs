using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public int? UserId { get; set; }

    public string? NumberPhone { get; set; }

    public string? ContentFeedback { get; set; }

    public int? Rating { get; set; }

    public string? TargetType { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual User? User { get; set; }
}

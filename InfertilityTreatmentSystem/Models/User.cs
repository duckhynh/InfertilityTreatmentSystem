using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? RoleId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual InfoDoctor? InfoDoctor { get; set; }

    public virtual Member? Member { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<TreatmentService> TreatmentServices { get; set; } = new List<TreatmentService>();

    public virtual ICollection<Blog> IdBlogs { get; set; } = new List<Blog>();
}

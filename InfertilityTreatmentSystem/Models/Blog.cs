using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.Models;

public partial class Blog
{
    public int IdBlog { get; set; }

    public string? Type { get; set; }

    public string? Top1 { get; set; }

    public string? Author { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

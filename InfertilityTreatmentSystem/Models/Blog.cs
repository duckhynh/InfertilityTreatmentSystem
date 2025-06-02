using System.ComponentModel.DataAnnotations;

public class Blog
{
    [Key]
    public int ID_Blog { get; set; }

    [StringLength(50)]
    public string Type { get; set; }

    [StringLength(50)]
    public string Top1 { get; set; }

    [StringLength(100)]
    public string Author { get; set; }
}
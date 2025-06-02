using System.ComponentModel.DataAnnotations.Schema;

public class StaffBlog
{
    [ForeignKey("User")]
    public int User_ID { get; set; }

    [ForeignKey("Blog")]
    public int ID_Blog { get; set; }

    public User User { get; set; }
    public Blog Blog { get; set; }
}
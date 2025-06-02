using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Notification
{
    [Key]
    public int Notification_ID { get; set; }

    [ForeignKey("User")]
    public int User_ID { get; set; }

    [StringLength(20)]
    public string Number_Phone { get; set; }

    [StringLength(500)]
    public string Content_Noti { get; set; }

    public DateTime Created_At { get; set; }

    public bool Is_Read { get; set; }

    public User User { get; set; }
}
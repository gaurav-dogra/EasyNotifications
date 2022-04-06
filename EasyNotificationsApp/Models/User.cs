using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyNotificationsApp.Models;

public class User
{
    public int ID { get; set; }

    [DataType(DataType.EmailAddress)]
    [StringLength(100)]
    //issue 1: make it unique field
    public string Email { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    [DataType(DataType.Password)]
    [StringLength(50)]
    //issue 2: encrypt before set; decrypt when get
    public string Password { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace EasyNotificationsApp.Models;

public class User
{
    public int Id { get; set; }

    [DataType(DataType.EmailAddress)]
    //issue:1 make it unique
    public string Email { get; set; }

    [DataType(DataType.Password)]
    //issue:2 encrypt on storage
    public string Password { get; set; }

}
